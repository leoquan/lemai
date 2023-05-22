using IdentityModel;
using LeMai.Efs;
using LeMaiApi.Models;
using LeMaiDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace LeMaiApi.Controllers;

/// <summary>
/// 
/// </summary>
public class TaiKhoanController : GhControllerBase<TaiKhoanController>
{
    private readonly LeMaiDbContext _dbCtx;
    private readonly IConfiguration _config;
    
    public TaiKhoanController(ILogger<TaiKhoanController> logger
        , LeMaiDbContext dbContext
        , IConfiguration config
        ) : base(logger)
    {
        _dbCtx = dbContext;
        _config = config;
    }

    /// <summary>
    /// Đăng nhập tài khoản lấy token
    /// </summary>
    /// <param name="env"></param>
    /// <param name="model"></param>
    /// <returns></returns>
    /// <exception cref="LogicException"></exception>
    [HttpPost]
    public async Task<ApiResult<TaiKhoanDangNhapOutput>> DangNhap(
        [FromServices] IWebHostEnvironment env,
        TaiKhoanDangNhapInput model)
    {
        var taiKhoan = await _dbCtx.ExpCustomers.AsNoTracking().FirstOrDefaultAsync(h =>
            h.CustomerCode == model.TenDangNhap
        );

        if (taiKhoan == null)
        {
            throw new LogicException("Tài khoản không tồn tại.");
        }
        else if (taiKhoan.CustomerCodePass != model.MatKhau)
        {
            throw new LogicException("Mật khẩu không chính xác.");
        }

        var tokenHandler = new JwtSecurityTokenHandler();
        var tokenKey = Encoding.UTF8.GetBytes(_config["Jwt:Key"]);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new Claim[]
            {
                new Claim(JwtClaimTypes.Name, taiKhoan.CustomerName),
                new Claim(JwtClaimTypes.Id, taiKhoan.Id),
                new Claim(ClaimTypes.UserData, "UserData")
            }),

            Audience = _config["Jwt:Audience"],
            Issuer = _config["Jwt:Issuer"],

            //Expires = DateTime.UtcNow.AddMinutes(_config.GetValue<double>("Jwt:ExpiresAccessToken")),
            Expires = DateTime.UtcNow.AddDays(30),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey),
                SecurityAlgorithms.HmacSha256Signature)
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);

        // Kiem tra co gan ket can ho

        var result = new TaiKhoanDangNhapOutput
        {
            Id = taiKhoan.Id,
            Code = taiKhoan.CustomerCode,
            HoTen = taiKhoan.CustomerName,
            SoDienThoai = taiKhoan.CustomerPhone,
            AccessToken = tokenHandler.WriteToken(token),
            AccessTimeoutUtc = tokenDescriptor.Expires?.ToString("yyyy-MM-dd HH:mm:ss"),
        };

        return CreateOk(result);
    }


    [Authorize]
    [HttpPost]
    public async Task<ApiResult<bool>> DoiMatKhau(TaiKhoanDoiMatKhauInput model)
    {
        var userId = GetLoginUserId();

        var taiKhoan = await _dbCtx.ExpCustomers.FirstOrDefaultAsync(h => h.Id == userId);
        if (taiKhoan == null)
        {
            throw new LogicException("Tài khoản không tồn tại.");
        }

        taiKhoan.CustomerCodePass = model.MatKhauMoi;

        await _dbCtx.SaveChangesAsync();


        return CreateOk(true);
    }




    [HttpPost]
    public async Task<ApiResult<bool>> DangKy(TaiKhoanDangKyInput model)
    {
        //var customerCode = model.SoDienThoai[^6..];
        var customerCode = model.SoDienThoai;

        var taiKhoan = await _dbCtx.ExpCustomers.AsNoTracking().FirstOrDefaultAsync(h =>
            h.CustomerCode == customerCode
        );

        if (taiKhoan != null)
        {
            throw new LogicException("Tài khoản đã tồn tại.");
        }

        taiKhoan = new ExpCustomer
        {
            Id = Guid.NewGuid().ToString(),
            CustomerName = model.HoTen,
            CustomerCode = customerCode,
            CustomerPhone= model.SoDienThoai,
            CustomerCodePass = model.MatKhau,
            ContractCustomer = false,
            FkPost = "VN80826"
        };

        _dbCtx.ExpCustomers.Add(taiKhoan);
        await _dbCtx.SaveChangesAsync();


        return CreateOk(true);
    }

    [Authorize]
    [HttpPost]
    public async Task<ApiResult<bool>> XoaTaiKhoan()
    {
        var userId = User.Claims.FirstOrDefault(h => h.Type == "id")?.Value;

        var taiKhoan = await _dbCtx.ExpCustomers.FirstOrDefaultAsync(h =>
            h.Id == userId
        );

        if (taiKhoan == null)
        {
            throw new LogicException("Tài khoản không tồn tại.");
        }

        taiKhoan.CustomerCode = "Delete_" + taiKhoan.CustomerCode;

        await _dbCtx.SaveChangesAsync();

        return CreateOk(true);
    }

}
