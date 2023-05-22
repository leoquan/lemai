using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace LeMaiApi.Filters;

[AttributeUsage(AttributeTargets.Class)]
public class SuppressModelStateInvalidFilterFactoryAttribute : Attribute, IControllerModelConvention
{
    public void Apply(ControllerModel controller)
    {
        foreach (var action in controller.Actions)
        {
            for (var i = 0; i < action.Filters.Count; i++)
            {
                if (action.Filters[i].GetType().Name == "ModelStateInvalidFilterFactory")
                {
                    action.Filters.RemoveAt(i);
                    break;
                }
            }
        }
    }
}