using LeMaiDomain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace LeMaiWebPublic.Controllers
{
	public class BaseController : Controller
	{
		protected readonly ILogger<BaseController> _logger;
		protected BaseController(ILogger<BaseController> logger)
		{
			this._logger = logger;
		}
		public string AtUserToken { get; set; }
		public override void OnActionExecuting(ActionExecutingContext context)
		{
			AtUserToken = GetAtUserToken();
			ViewBag.AtUserToken = AtUserToken;
			base.OnActionExecuting(context);
		}
		public override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
		{
			AtUserToken = GetAtUserToken();
			ViewBag.AtUserToken = AtUserToken;
			return base.OnActionExecutionAsync(context, next);
		}
		private string GetAtUserToken()
		{
			if (!User.Identity.IsAuthenticated)
			{
				return "";
			}
			return User.Claims.FirstOrDefault(h => h.Type == "AtUserToken")?.Value;
		}
		public string GetUserId()
		{
			if (!User.Identity.IsAuthenticated)
			{
				return "";
			}
			return User.Claims.FirstOrDefault(h => h.Type == "userId")?.Value;
		}
        public string GetPost()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return "";
            }
            return User.Claims.FirstOrDefault(h => h.Type == "post")?.Value;
        }
        public string GetFee()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return "";
            }
            return User.Claims.FirstOrDefault(h => h.Type == "FeeId")?.Value;
        }
        public string GetUserName()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return "";
            }
            return User.Claims.FirstOrDefault(h => h.Type == ClaimTypes.Name)?.Value;
        }
        protected string HandleException(Exception ex, bool addErrorToModelState)
		{
			var errorId = ExceptionHelpers.NewErrorId();
			_logger.LogError(ex, ExceptionHelpers.GetMessage(errorId, ex.Message));

			if (addErrorToModelState)
			{
				ModelState.AddModelError("", "Đã có lỗi xảy ra trong quá trình xử lý. Vui lòng liên hệ nhà quản trị với mã lỗi: " + errorId);
			}
			return errorId;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="data"></param>
		/// <returns></returns>
		protected static ActionResult<ApiResultDto<T>> CreateResult<T>(T data)
		{
			return new ActionResult<ApiResultDto<T>>(new ApiResultDto<T>(data));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="errorCode"></param>
		/// <returns></returns>
		protected static ActionResult<ApiResultDto<T>> CreateError<T>(ErrorCodeEnum errorCode)
		{
			return new ActionResult<ApiResultDto<T>>(new ApiResultDto<T>(default) { IsOk = false, ErrorCode = errorCode });
		}
	}
	internal static class ExceptionHelpers
	{
		public static string NewErrorId()
		{
			return $"{DateTime.UtcNow.ToString("ddMMyy_HHmmss")}_{Guid.NewGuid().ToString().Substring(0, 8)}";
		}

		public static string GetMessage(in string errorId, in string message)
		{
			return $"Error Id: {errorId} | {message}";
		}
	}
}

