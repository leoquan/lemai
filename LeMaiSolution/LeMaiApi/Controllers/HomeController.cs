using LeMaiDomain;
using LeMaiLogic;
using LeMaiLogic.Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeMaiApi.Controllers
{
	public class HomeController : BaseController
	{
		private readonly IConfiguration _configuration;
		private readonly UserManagerLogic _logic;
		public HomeController(ILogger<BaseController> logger, IConfiguration config) : base(logger)
		{
			_configuration = config;
			BaseLogicConnectionData connection = new BaseLogicConnectionData();
			connection.ConnectionString = _configuration["DefaultConnection"];
			connection.Schema = _configuration["DefaultSheme"];
			_logic = new UserManagerLogic(connection);
		}
	}
}


