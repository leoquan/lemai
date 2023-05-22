using LeMai.Efs;
using LeMaiApi.Controllers;
using LeMaiApi.Filters;
using LeMaiApi.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Serilog;
using Serilog.Events;
using Swashbuckle.AspNetCore.Filters;
using System.Globalization;
using System.Reflection;
using System.Text;

Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
            .Enrich.FromLogContext()
            .WriteTo.Console()
            .CreateBootstrapLogger();

try
{
    Log.Information("Starting web host");

    var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.

    builder.Host.UseSerilog((context, services, configuration) => configuration
        .ReadFrom.Configuration(context.Configuration)
        .ReadFrom.Services(services)
        .Enrich.FromLogContext()
        .Filter.ByExcluding(logEvent => logEvent.Exception is LogicException)
        .WriteTo.Console()
    );

    builder.Services.AddDbContext<LeMaiDbContext>(options =>
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("LeMaiDbContext"));
    });

    //builder.Services.Configure<RequestLocalizationOptions>(options =>
    //{
    //    var supportedCultures = new[]
    //    {
    //        new CultureInfo("en-US"),
    //    };
    //    var supportedUICultures = new[]
    //    {
    //        new CultureInfo("vi-VN"),
    //        new CultureInfo("en-US"),
    //    };
    //    options.DefaultRequestCulture = new RequestCulture(
    //        culture: "en-US",
    //        uiCulture: "vi-VN"
    //    );
    //    options.SupportedCultures = supportedCultures;
    //    options.SupportedUICultures = supportedUICultures;

    //    options.AddInitialRequestCultureProvider(new CustomRequestCultureProvider(context =>
    //    {
    //        var parts = context.Request.Path.Value.Split('/');
    //        if (parts.Length > 3
    //            && "api".Equals(parts[1], StringComparison.OrdinalIgnoreCase)
    //            && supportedUICultures.Any(h => h.Name.Equals(parts[2], StringComparison.OrdinalIgnoreCase))
    //            )
    //        {
    //            return Task.FromResult(new ProviderCultureResult(culture: "en-US", uiCulture: parts[2]));
    //        }

    //        return Task.FromResult<ProviderCultureResult>(null); ;
    //    }));
    //});

    builder.Services.AddControllers()
        //.AddDataAnnotationsLocalization()
        .AddJsonOptions(options =>
        {
            options.JsonSerializerOptions.PropertyNamingPolicy = null;
            //options.JsonSerializerOptions.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
        })
        .ConfigureApiBehaviorOptions(options =>
        {
            //options.SuppressModelStateInvalidFilter = true;

            //// To preserve the default behavior, capture the original delegate to call later.
            //var builtInFactory = options.InvalidModelStateResponseFactory;

            //options.InvalidModelStateResponseFactory = context =>
            //{
            //    //var logger = context.HttpContext.RequestServices
            //    //                    .GetRequiredService<ILogger<Program>>();
            //    //// Perform logging here.
            //    //// ...

            //    if (context.H)
            //    {

            //    }

            //    // Invoke the default behavior, which produces a ValidationProblemDetails
            //    // response.
            //    // To produce a custom response, return a different implementation of 
            //    // IActionResult instead.
            //    return builtInFactory(context);
            //};
        });

    builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
    {
        options.RequireHttpsMetadata = false;
        options.SaveToken = true;
        options.TokenValidationParameters = new TokenValidationParameters()
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidAudience = builder.Configuration["Jwt:Audience"],
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
        };
    });

    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen(option =>
    {
        //option.UseAllOfForInheritance();

        option.OrderActionsBy((apiDesc) =>
        {
            var controllerName = $"{apiDesc.ActionDescriptor.RouteValues["controller"]}Controller";
            var actionName = apiDesc.ActionDescriptor.RouteValues["action"];
            int index;
            if (controllerName == nameof(TaiKhoanController))
            {
                if (actionName == nameof(TaiKhoanController.DangNhap))
                {
                    index = 0;
                }
                else
                {
                    index = 1;
                }
            }
            else
            {
                index = 2;
            }

            return $"{index};{controllerName};{actionName}";
        });

        // using System.Reflection;
        var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
        option.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
        option.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "LeMaiDto.xml"));

        option.SchemaFilter<GhSchemaFilter>();
        option.OperationFilter<GhOperationFilter>();
        option.DocumentFilter<GhDocumentFilter>();

        option.OperationFilter<AppendAuthorizeToSummaryOperationFilter>();
        option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
        {
            In = ParameterLocation.Header,
            Description = "Please enter a valid token",
            Name = "Authorization",
            Type = SecuritySchemeType.Http,
            BearerFormat = "JWT",
            Scheme = "Bearer"
        });
        option.OperationFilter<SecurityRequirementsOperationFilter>(true, "Bearer");
        //option.AddSecurityRequirement(new OpenApiSecurityRequirement
        //{
        //    {
        //        new OpenApiSecurityScheme
        //        {
        //            Reference = new OpenApiReference
        //            {
        //                Type=ReferenceType.SecurityScheme,
        //                Id="Bearer"
        //            }
        //        },
        //        new string[]{}
        //    }
        //});



    });

    builder.Services.AddMemoryCache();

    var app = builder.Build();

    app.UseSerilogRequestLogging();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI(c => {
            c.EnableFilter();
            c.DefaultModelExpandDepth(3);
            c.DefaultModelsExpandDepth(3);
        });

        //app.UseExceptionHandler("/error-development");
        app.UseExceptionHandler("/error");
    }
    else
    {
        app.UseSwagger();
        app.UseSwaggerUI(c => {
            c.EnableFilter();
            c.DefaultModelExpandDepth(3);
            c.DefaultModelsExpandDepth(3);
        });

        app.UseExceptionHandler("/error");
    }


    app.UseHttpsRedirection();

    app.UseAuthentication();
    app.UseAuthorization();

    // start code to add
    // to get ip address
    app.UseForwardedHeaders(new ForwardedHeadersOptions
    {
        ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
    });
    // end code to add

    //var localizationOptions = app.Services.GetService<IOptions<RequestLocalizationOptions>>().Value;
    //app.UseRequestLocalization(localizationOptions);

    app.MapControllers();

    app.Run();
    return 0;
}
catch (Exception ex)
{
    Log.Fatal(ex, "Host terminated unexpectedly");
    return 1;
}
finally
{
    Log.CloseAndFlush();
}