using LeMai.Efs;
using LeMaiApi.Models;
using LeMaiDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using System.ComponentModel.DataAnnotations;

namespace LeMaiApi.Controllers;

[Authorize]
public class AppInfoController : GhControllerBase<AppInfoController>
{
    private readonly IConfiguration _config;

    public AppInfoController(ILogger<AppInfoController> logger
         , IConfiguration config
         ) : base(logger)
    {
        _config = config;
    }

    [HttpGet]
    [AllowAnonymous]
    public async Task<ApiResult<bool>> CheckIsTesting()
    {
        var result = _config.GetValue<bool>("App_IsTesting");
        return CreateOk(result);
    }

    [HttpGet]
    [AllowAnonymous]
    public async Task<ApiResult<string>> GetConnectionString(
        [Required] string username,
        [Required] string password,
        [FromServices] IConfiguration config,
        [FromServices] LeMaiDbContext dbContext
        )
    {
        if (username != config.GetValue<string>("AppInfo:Username")
            || password != config.GetValue<string>("AppInfo:Password"))
        {
            throw new LogicException("Invalid user");
        }
        var result = dbContext.Database.GetConnectionString();
        return CreateOk(result);
    }
}





