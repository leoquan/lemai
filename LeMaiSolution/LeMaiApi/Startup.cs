using FluentValidation.AspNetCore;
using LeMaiApi.Controllers;
using LeMaiApi.Models;
using LeMaiLogic;
using LeMaiLogic.Logic;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace LeMaiApi
{
	public class Startup
	{
		public const string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}
		public IConfiguration Configuration { get; }
	  
		public IDistributedCache Cache { get; set; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllersWithViews()
		 .AddNewtonsoftJson(options =>
		 {
			 // Return JSON responses in LowerCase?
			 options.SerializerSettings.ContractResolver = new DefaultContractResolver();
			 // Resolve Looping navigation properties
			 options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
		 });

			//services.AddDbContext<DataFrameworkWebContext>(options =>
			//  options.UseSqlServer(
			//	  Configuration.GetConnectionString("DefaultConnection")));

			services.AddResourceData("", "");

		 
	  
			// Register the Swagger generator, defining 1 or more Swagger documents
			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new OpenApiInfo
				{
					Version = "v1",
					Title = "LeMai WEBSITE",
					Description = "ASP.NET Core Web API of LeMai Project!",
					TermsOfService = new Uri("https://atsolution.info/terms"),
					Contact = new OpenApiContact
					{
						Name = "Shayne Boyer",
						Email = string.Empty,
						Url = new Uri("https://atsolution.info/gioithieu"),
					},
					License = new OpenApiLicense
					{
						Name = "Use under LICX",
						Url = new Uri("https://atsolution.info"),
					}
				});

				// JWT-token authentication by password
				c.OperationFilter<AuthResponsesOperationFilter>();

				c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
				{
					Name = "Authorization",
					Description = "JWT Authorization header using the Bearer scheme.",

					Scheme = "bearer",
					BearerFormat = "JWT",

					In = ParameterLocation.Header,
					Type = SecuritySchemeType.Http
				});


				var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
				var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
				c.IncludeXmlComments(xmlPath, true);

			});


			services.AddControllers();


			//JWT


			services.AddAuthentication()
				.AddJwtBearer(cfg =>
				{
					//cfg.RequireHttpsMetadata = false;
					//cfg.SaveToken = true;
					cfg.TokenValidationParameters = TokenController.GetTokenValidationParameters(Configuration, true);
					cfg.Events = new JwtBearerEvents
					{
						OnTokenValidated = async context =>
						{
							var jwtToken = (JwtSecurityToken)context.SecurityToken;
							var userId = TokenController.GetClaimsUserId(jwtToken.Claims);
							var device = TokenController.GetClaimsDevice(jwtToken.Claims);

							var accessToken = TokenController.GetCacheAccessTokenAsync(Cache, userId, device);

							if (context.SecurityToken.Id != accessToken)
							{
								var refreshToken = TokenController.GetCacheRefreshTokenAsync(Cache, userId, device);

								if (string.IsNullOrWhiteSpace(refreshToken))
								{
									context.Response.Headers.Add("Token-Revoked", "Access-Refresh");
									context.Fail("Token-Revoked-Access-Refresh");
								}
								else
								{
									context.Response.Headers.Add("Token-Revoked", "Access");
									context.Fail("Token-Revoked-Access");
								}
							}

							return;
						},
						OnAuthenticationFailed = async context =>
						{
							if (context.Exception.GetType() == typeof(SecurityTokenExpiredException))
							{

								if (context.Principal != null)
								{
									context.Response.Headers.Add("Token-Expired", "Access");
									var userId = TokenController.GetClaimsUserId(context.Principal.Claims);
									var device = TokenController.GetClaimsDevice(context.Principal.Claims);


									var refreshToken = TokenController.GetCacheRefreshTokenAsync(Cache, userId, device);

									if (string.IsNullOrWhiteSpace(refreshToken))
									{
										context.Response.Headers.Add("Token-Revoked", "Refresh");
									}
								}

							}
						}
					};
				});
			;



			services.AddMemoryCache();




			services.AddCors(options =>
			{
				options.AddPolicy(MyAllowSpecificOrigins,
				builder => builder
						   .AllowAnyOrigin()
						   .AllowAnyHeader()
						   .AllowAnyMethod()

				);
			});

			// Validators Controller AcccountObject

			//services.AddSingleton<IValidator<LoginDto>, UserLoginValidation>();
			//services.AddSingleton<IValidator<Informtion_Input>, EmployeeValidation>();

			// mvc + validating
			services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0).AddFluentValidation();

			// override modelstate
			services.Configure<ApiBehaviorOptions>(options =>
			{
				options.InvalidModelStateResponseFactory = (context) =>
				{
					var errors = context.ModelState.Values.SelectMany(x => x.Errors.Select(p => p.ErrorMessage)).ToList();
					var result = new
					{
						Code = "400",
						Message = "Validation errors",
						Errors = errors
					};
					return new BadRequestObjectResult(result);
				};
			});
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IDistributedCache cache, ILogger<Startup> logger)
		{
			Cache = cache;

			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}


			app.ConfigureExceptionHandler(logger);

			app.UseHttpsRedirection();

			app.UseStaticFiles();

			// Enable middleware to serve generated Swagger as a JSON endpoint.
			app.UseSwagger();

			// Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
			// specifying the Swagger JSON endpoint.
			app.UseSwaggerUI(c =>
			{
				c.SwaggerEndpoint("/swagger/v1/swagger.json", "LeMai API V1");
			});


			app.UseRouting();

			app.UseCors(MyAllowSpecificOrigins);

			app.UseAuthentication();
			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}

	/// <summary>
	/// 
	/// </summary>
	public class AuthResponsesOperationFilter : IOperationFilter
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="operation"></param>
		/// <param name="context"></param>
		public void Apply(OpenApiOperation operation, OperationFilterContext context)
		{
			var authAttributes = context.MethodInfo.DeclaringType.GetCustomAttributes(true)
				.Union(context.MethodInfo.GetCustomAttributes(true))
				.OfType<AuthorizeAttribute>();

			if (authAttributes.Any())
			{
				operation.Responses.Add("401", new OpenApiResponse { Description = "Unauthorized" });
				operation.Responses.Add("403", new OpenApiResponse { Description = "Forbidden" });

				operation.Security.Add(new OpenApiSecurityRequirement
				{
					{
						new OpenApiSecurityScheme
						{
							Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "Bearer" }
						},
						new List<string>()
					}
				});
			}

		}
	}
}
