using LeMaiDomain;
using LeMaiLogic;
using LeMaiLogic.Logic;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeMaiApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UsesManagerController : BaseController
	{
		private readonly UserManagerLogic _logic;
		private readonly IConfiguration _configuration;
		/// <summary>
		/// 
		/// </summary>
		/// <param name="logger"></param>
		/// <param name="config"></param>
		public UsesManagerController(ILogger<UsesManagerController> logger,
			IConfiguration config) : base(logger)
		{
			_configuration = config;
			BaseLogicConnectionData connection = new BaseLogicConnectionData();
			connection.ConnectionString = _configuration["DefaultConnection"];
			connection.Schema = _configuration["DefaultSheme"];
			_logic = new UserManagerLogic(connection);
		}

		//[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
		[HttpGet(nameof(GetUserProfile))]
		public async Task<ActionResult<ApiResultDto<AccountObject>>> GetUserProfile(string UserID)
		{
			try
			{
				var profile = await _logic.GetAccountObject(UserID).ConfigureAwait(_configAwait);

				if (profile != null)
				{
					return CreateResult(profile);
				}
				else
				{
					return CreateError<AccountObject>(ErrorCodeEnum.LoginFail);
				}
			}
			catch (Exception ex)
			{
				return HandleException<AccountObject>(ex);
			}
		}
		[HttpPost(nameof(UpdateUserProfile))]
		public async Task<ActionResult<ApiResultDto<int>>> UpdateUserProfile([FromBody] UpdateProfileInput input)
		{
			try
			{
				var result = await _logic.UpdateProfileUser(input).ConfigureAwait(_configAwait);
				return CreateResult(result);
			}
			catch (Exception ex)
			{
				return HandleException<int>(ex);
			}
		}
	}
}

