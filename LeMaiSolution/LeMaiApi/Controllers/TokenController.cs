using LeMaiApi.Models;
using LeMaiDomain;
using LeMaiLogic;
using LeMaiLogic.Logic;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LeMaiApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TokenController : BaseController
	{

		private readonly IConfiguration _configuration;
		private readonly IDistributedCache _cache;
		private readonly UserManagerLogic _logicUserManager;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="logger"></param>
		/// <param name="config"></param>
		/// <param name="cache"></param>
		public TokenController(
		   ILogger<TokenController> logger,
		   IConfiguration config,
		   IDistributedCache cache
		   ) : base(logger)
		{
			_configuration = config;
			_cache = cache;
			BaseLogicConnectionData connection = new BaseLogicConnectionData();
			connection.ConnectionString = _configuration["DefaultConnection"];
			connection.Schema = _configuration["DefaultSheme"];
			_logicUserManager = new UserManagerLogic(connection);
		}


		[HttpPost(nameof(Login))]
		public async Task<ActionResult<ApiResultDto<TokenDto>>> Login([FromBody] LoginDto model)
		{
			try
			{
				var userId = await _logicUserManager.LoginAsync(model.Username, model.Password, model.Device).ConfigureAwait(_configAwait);

				if (!string.IsNullOrEmpty(userId))
				{
					var token = await GenerateTokenAsync(model.Username, model.Device, userId).ConfigureAwait(false);
				   
					return CreateResult(token);
				}
				else
				{
					return CreateError<TokenDto>(ErrorCodeEnum.LoginFail);
				}
			}
			catch (Exception ex)
			{
				return HandleException<TokenDto>(ex);
			}
		}

		[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
		[HttpPost(nameof(Logout))]
		public async Task<IActionResult> Logout()
		{
			var userId = GetClaimsUserId(User.Claims);
			var device = GetClaimsDevice(User.Claims);

			var keyAccessToken = CachingHelpers.GetKeyAccessToken(userId, device);
			_cache.Remove(keyAccessToken);

			var keyRefressToken = CachingHelpers.GetKeyRefreshToken(userId, device);
			_cache.Remove(keyRefressToken);

			return Ok();
		}

		[HttpPost(nameof(RefreshToken))]
		public async Task<ActionResult<ApiResultDto<TokenDto>>> RefreshToken([FromBody] RefreshDto model)
		{
			var principal = GetPrincipalFromExpiredToken(model.AccessToken);
			if (principal == null)
			{
				Response.Headers.Add("Token-Invalid", "Access");
				return BadRequest("Token-Invalid-Access");
			}

			var userId = GetClaimsUserId(principal.Claims);
			var device = GetClaimsDevice(principal.Claims);

			var valueRefreshToken = GetCacheRefreshTokenAsync(_cache, userId, device);
			if (valueRefreshToken != model.RefreshToken)
			{
				Response.Headers.Add("Token-Invalid", "Refresh");
				return BadRequest("Token-Invalid-Refresh");
			}

			var token = await GenerateTokenAsync(userId, device, principal.Claims).ConfigureAwait(false);

			return new ApiResultDto<TokenDto>(token);
		}

		private (string tokenId, string token, DateTime expires) GenerateJwtToken(in string username, in string device, string userID)
		{
			var claims = new List<Claim>
			{
				new Claim(JwtRegisteredClaimNames.Sub, username), // Cho jwt token
				new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
				new Claim(ClaimTypes.Name, username), // cho cookie
				new Claim(LeMaiClaimType.ID, userID),
				new Claim(LeMaiClaimType.DEVICE, $"{device}")
			};


			return GenerateJwtToken(claims);
		}
		private (string tokenId, string token, DateTime expires) GenerateJwtToken(IEnumerable<Claim> listClaim)
		{
			var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtKey"]));
			var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

			var time = _configuration.GetValue<int>("JwtExpireMinutes");

			var expires = DateTime.Now.AddMinutes(_configuration.GetValue<int>("JwtExpireMinutes"));

			var token = new JwtSecurityToken(
				_configuration["JwtIssuer"],
				_configuration["JwtIssuer"],
				listClaim,
				expires: expires,
				signingCredentials: creds
			);

			return (token.Id, new JwtSecurityTokenHandler().WriteToken(token), token.ValidTo);
		}

		private ClaimsPrincipal GetPrincipalFromExpiredToken(string token)
		{
			var tokenValidationParameters = GetTokenValidationParameters(_configuration, false);

			var tokenHandler = new JwtSecurityTokenHandler();
			var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out SecurityToken securityToken);
			if (!(securityToken is JwtSecurityToken jwtSecurityToken)
				|| !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
			{
				//throw new SecurityTokenException("Invalid token");
				return null;
			}

			return principal;
		}

		[NonAction]
		public static string GetCacheRefreshTokenAsync(IDistributedCache cache, in string userId, in string device)
		{
			var key = CachingHelpers.GetKeyRefreshToken(userId, device);
			return cache.GetString(key);
		}
		[NonAction]
		public static string GetCacheAccessTokenAsync(IDistributedCache cache, in string userId, in string device)
		{
			var key = CachingHelpers.GetKeyAccessToken(userId, device);
			return cache.GetString(key);
		}

		private Task<TokenDto> GenerateTokenAsync(string username, string device, string userID)
		{
			var (accessTokenId, accessToken, expiresAccessToken) = GenerateJwtToken(username, device, userID);

			return GenerateTokenAsync(
			   accessTokenId, accessToken, expiresAccessToken,
			   userID, device);
		}
		private Task<TokenDto> GenerateTokenAsync(string userId, string device, IEnumerable<Claim> listClaims)
		{
			var (accessTokenId, accessToken, expiresAccessToken) = GenerateJwtToken(listClaims);

			return GenerateTokenAsync(
				accessTokenId, accessToken, expiresAccessToken,
				userId, device);
		}
		private async Task<TokenDto> GenerateTokenAsync(
			string accessTokenId, string accessToken, DateTime expiresAccessToken,
			string userId, string device)
		{
			try
			{
				var keyAccess = CachingHelpers.GetKeyAccessToken(userId, device);

				_cache.SetString(keyAccess, accessTokenId, new DistributedCacheEntryOptions
				{
					AbsoluteExpiration = expiresAccessToken

				});

				var randomNumber = new byte[32];
				using var rng = RandomNumberGenerator.Create();
				rng.GetBytes(randomNumber);
				var refreshToken = Convert.ToBase64String(randomNumber);

				var expiresRefreshToken = DateTime.Now.AddDays(_configuration.GetValue<int>("JwtRefreshExpireDays"));
				var keyRefresh = CachingHelpers.GetKeyRefreshToken(userId, device);

				_cache.SetString(keyRefresh, refreshToken, new DistributedCacheEntryOptions
				{
					AbsoluteExpiration = expiresRefreshToken

				});

				return new TokenDto { AccessToken = accessToken, RefreshToken = refreshToken, ExpiresRefreshToken = expiresRefreshToken , UserId = userId };
			}
			catch (Exception ex)
			{

				throw ex;
			}

		}


		[NonAction]
		public static TokenValidationParameters GetTokenValidationParameters(IConfiguration config, bool validateLifetime)
		{
			var tokenValidationParameters = new TokenValidationParameters
			{
				ValidateIssuer = true,
				ValidIssuer = config["JwtIssuer"],

				ValidateAudience = true,
				ValidAudience = config["JwtIssuer"],

				ValidateIssuerSigningKey = true,
				IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["JwtKey"])),

				ValidateLifetime = validateLifetime
			};

			return tokenValidationParameters;
		}

		[NonAction]
		public static string GetClaimsUserId(IEnumerable<Claim> listClaims)
		{
			return listClaims.FirstOrDefault(h => h.Type == LeMaiClaimType.ID)?.Value;
		}
		[NonAction]
		public static string GetClaimsDevice(IEnumerable<Claim> listClaims)
		{
			return listClaims.FirstOrDefault(h => h.Type == LeMaiClaimType.DEVICE)?.Value;
		}
	}
}
