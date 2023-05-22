using LeMaiDto;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Collections;

namespace LeMaiApi.Filters;

public class GhOperationFilter : IOperationFilter
{
    private readonly IConfiguration _config;

    public GhOperationFilter(IConfiguration config)
    {
        _config = config;
    }

    public void Apply(OpenApiOperation operation, OperationFilterContext context)
    {
        if (string.IsNullOrWhiteSpace(_config["SwaggerExample:uiCulture"]))
        {
            return;
        }

        foreach (var item in operation.Parameters)
        {
            if (item.In == ParameterLocation.Path && item.Name == "uiCulture")
            {
                item.Example = new OpenApiString(_config["SwaggerExample:uiCulture"]);
            }
        }
    }
}

public class GhSchemaFilter : ISchemaFilter
{
    public void Apply(OpenApiSchema schema, SchemaFilterContext context)
    {
        //foreach (var key in context.SchemaRepository.Schemas.Keys)
        //{
        //    //context.SchemaRepository.Schemas.Remove(key);
        //    if (key != "ReceiveSmsInput")
        //    {
        //        context.SchemaRepository.Schemas.Remove(key);
        //    }
        //    else
        //    {

        //    }
        //}

        // Format lại tên của các class generic
        if (context.Type.IsGenericType && context.MemberInfo == null)
        {
            var name = GetDisplayGenericName(context.Type);
            schema.Title = name;
        }


    }

    private string GetDisplayGenericName(Type t)
    {
        if (t.IsArray || !t.IsGenericType)
        {
            return t.Name;
        }

        var gnrParam = t.GetGenericArguments();
        var gnrParamName = new List<string>(gnrParam.Length);
        foreach (var item in gnrParam)
        {
            gnrParamName.Add(GetDisplayGenericName(item));
        }

        if (t.GetInterface(nameof(IEnumerable)) == null)
        {
            return $"{t.Name[..^2]}<{string.Join(", ", gnrParamName)}>";
        }
        else
        {
            return $"{string.Join(", ", gnrParamName.Select(h => $"{h}[]"))}";
        }


    }
}

public class GhDocumentFilter : IDocumentFilter
{
    private readonly IConfiguration _config;

    public GhDocumentFilter(IConfiguration config)
    {
        _config = config;
    }

    public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
    {
//        //remove paths those start with /api/abp prefix
//        swaggerDoc.Paths.Where(x =>
//            !x.Key.ToLowerInvariant().StartsWith("/api/{uiculture}/sms")
//#if DEBUG
//            && !x.Key.ToLowerInvariant().StartsWith("/api/{uiculture}/thietlap")
//#endif

//            )
//            .ToList()
//            .ForEach(x =>
//            {
//                swaggerDoc.Paths.Remove(x.Key);
//            });

        // Tìm các response là dạng danh sách để bỏ đi phần hiện kiểu dữ liệu
        foreach (var itemPath in swaggerDoc.Paths)
        {
            foreach (var itemOperation in itemPath.Value.Operations)
            {
                foreach (var itemResponse in itemOperation.Value.Responses)
                {
                    foreach (var itemContent in itemResponse.Value.Content)
                    {
                        if (itemContent.Value.Schema.Type == "array")
                        {
                            itemContent.Value.Schema.Title = null;
                        }
                    }
                }
            }
        }

        var swaggerExample = _config.GetSection("SwaggerExample");
        var listClass = swaggerExample.GetChildren().ToList();
        foreach (var itemClass in listClass)
        {
            if (swaggerDoc.Components.Schemas.TryGetValue(itemClass.Key, out OpenApiSchema itemSchema))
            {
                var listProp = itemClass.GetChildren().ToList();
                foreach (var itemProp in listProp)
                {
                    if (itemSchema.Properties.ContainsKey(itemProp.Key))
                    {
                        itemSchema.Properties[itemProp.Key].Example = new OpenApiString(itemProp.Value);
                    }
                }
            }
        }

    }
}