using LeMaiApi.Models;
using LeMaiDto;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;

namespace LeMaiApi.Controllers;

[ApiController]
[Route("[controller]")]
[ApiExplorerSettings(IgnoreApi = true)]
public class ErrorController : ControllerBase
{

    public ErrorController()
    {
    }

    [Route("/error-development")]
    public IActionResult HandleErrorDevelopment(
    [FromServices] IHostEnvironment hostEnvironment)
    {
        if (!hostEnvironment.IsDevelopment())
        {
            return NotFound();
        }

        var exceptionHandlerFeature =
            HttpContext.Features.Get<IExceptionHandlerFeature>()!;

        return Problem(
            detail: exceptionHandlerFeature.Error.StackTrace,
            title: exceptionHandlerFeature.Error.Message);
    }

    [Route("/error")]
    public IActionResult HandleError()
    {
        var traceId = HttpContext.TraceIdentifier;
        var exception =
           HttpContext.Features.Get<IExceptionHandlerFeature>()!;

        return HandelJson(traceId, exception, HttpContext);
    }
        

    private JsonResult HandelJson(in string traceId, in IExceptionHandlerFeature exception, in HttpContext httpContext)
    {
        if (exception == null)
        {
            httpContext.Response.StatusCode = 200;
            return new JsonResult(new ApiResult("Lỗi không có exception"));
        }
        else if (exception.Error is LogicException logicEx)
        {
            httpContext.Response.StatusCode = 200;

            if (logicEx.ListErrors != null && logicEx.ListErrors.Count > 0)
            {
                return new JsonResult(new ApiResult(logicEx.ListErrors, status: logicEx.Status));
            }
            else
            {
                return new JsonResult(new ApiResult(logicEx.Message, status: logicEx.Status));
            }
        }
        else if (exception.Error is DbUpdateConcurrencyException concurrEx)
        {
            httpContext.Response.StatusCode = 200;
            return new JsonResult(new ApiResult("Lỗi DB concurrent conflict", status: ApiStatus.ConcurrencyError));
        }
        else
        {
#if DEBUG
            return new JsonResult(new ApiResult("Lỗi chưa được xử lý", traceId) { DebugException = exception?.Error?.ToString() });
#endif
            return new JsonResult(new ApiResult("Lỗi chưa được xử lý", traceId));
        }
    }

}
