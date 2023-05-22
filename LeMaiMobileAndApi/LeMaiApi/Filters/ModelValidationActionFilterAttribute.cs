using LeMaiApi.Controllers;
using LeMaiApi.Models;
using LeMaiDto;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace LeMaiApi.Filters;

public class ModelValidationActionFilterAttribute : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        base.OnActionExecuting(context);

        if (!context.ModelState.IsValid)
        {
            var listError = new List<ApiError>(context.ModelState.Keys.Count());
            foreach (var itemKey in context.ModelState.Keys)
            {
                var itemValue = context.ModelState[itemKey];
                if (itemValue.ValidationState != ModelValidationState.Invalid)
                {
                    continue;
                }

                listError.AddRange(itemValue.Errors.Select(h => new ApiError(itemKey, h.ErrorMessage)));
            }

            throw new LogicException(listError) { Status = ApiStatus.InvalidModel };
        }
    }
}