using LeMaiLogic;
using LeMaiLogic.Logic;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeMaiApi
{
	public static class ServiceRegistration
	{
		public static void AddResourceData(this IServiceCollection services, string connectionString, string dbName)
		{
			services.AddScoped<BaseLogicConnectionData>();
			services.AddScoped<BaseLogic>();
			services.AddScoped<UserManagerLogic>();
			//services.AddScoped<ServiceLogic>();
		}
	}
}

