using LeMaiApi.Filters;
using LeMaiDto;
using IdentityModel;
using Microsoft.AspNetCore.Mvc;

namespace LeMaiApi.Controllers;

[ApiController]
[ModelValidationActionFilter]
[SuppressModelStateInvalidFilterFactory]
[Route("api/[controller]/[action]")]
[Consumes("application/json")]
[Produces("application/json")]
public abstract class GhControllerBase<TControler> : ControllerBase where TControler : ControllerBase
{
    protected readonly ILogger<GhControllerBase<TControler>> _logger;

    public GhControllerBase(ILogger<GhControllerBase<TControler>> logger)
    {
        _logger = logger;
    }

    protected ApiResult<T> CreateOk<T>(in T data)
    {
        return new ApiResult<T>(data);
    }

    protected string GetLoginUserId()
    {
        if (User.Identity.IsAuthenticated)
        {
            return User.Claims.FirstOrDefault(h=> h.Type == JwtClaimTypes.Id)?.Value ?? "UNKNOW";
        }

        return "SYSTEM";
    }
    
    protected DateTime GetDateNow()
    {
        return DateTime.Now;
    }
}