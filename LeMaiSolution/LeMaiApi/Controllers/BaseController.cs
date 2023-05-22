using LeMaiApi.Models;
using LeMaiDomain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeMaiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Consumes("application/json")]
    [Produces("application/json")]
    public abstract class BaseController : ControllerBase
    {
        internal static bool _configAwait = false;

        protected readonly ILogger<BaseController> _logger;
        protected BaseController(ILogger<BaseController> logger)
        {
            this._logger = logger;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ex"></param>
        /// <returns></returns>
        protected ActionResult<ApiResultDto<T>> HandleException<T>(Exception ex)
        {
            var errorId = ExceptionHelpers.NewErrorId();
            _logger.LogError(ex, ExceptionHelpers.GetMessage(errorId, ex.Message));

            if (ex is LogicException logicEx)
            {
                return new ActionResult<ApiResultDto<T>>(new ApiResultDto<T>(default)
                {
                    ErrorId = errorId,
                    ErrorCode = logicEx.ErrorCode
                });
            }
            //else if (ex is ValidationException validationEx)
            //{
            //	return new ActionResult<ApiResultDto<T>>(new ApiResultDto<T>(default)
            //	{
            //		ErrorId = errorId,
            //		ErrorCode = ErrorCodeEnum.ValidationFail,
            //		ListValidation = validationEx.ListError
            //	});
            //}

            return new ActionResult<ApiResultDto<T>>(new ApiResultDto<T>(default)
            {
                ErrorId = errorId,
                ErrorCode = ErrorCodeEnum.UnknowApi
            });
        }
        //protected void CheckValidation()
        //{
        //	if (ModelState.IsValid)
        //	{
        //		return;
        //	}

        //	var listError = new List<ValidationDto>(ModelState.ErrorCount);
        //	foreach (var itemState in ModelState)
        //	{
        //		foreach (var item in itemState.Value.Errors)
        //		{
        //			listError.Add(new ValidationDto
        //			{
        //				Key = itemState.Key,
        //				Message = item.ErrorMessage
        //			});
        //		}
        //	}

        //	throw new ValidationException() { ListError = listError };
        //}
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
        protected static ActionResult<ApiResultDto<T>> CreateError<T>(ErrorCodeEnum errorCode, string errorMessage)
        {
            return new ActionResult<ApiResultDto<T>>(new ApiResultDto<T>(default) { IsOk = false, ErrorCode = errorCode, ErrorMessage = errorMessage });
        }
        protected string GetUserId()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return "";
            }
            return $"{User.Claims.FirstOrDefault(h => h.Type == LeMaiClaimType.ID)?.Value}";
        }


    }
}


