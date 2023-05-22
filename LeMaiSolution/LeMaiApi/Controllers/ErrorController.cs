using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeMaiApi.Controllers
{
	/// <summary>
	/// Hệ thống lỗi của framework
	/// </summary>
	[ApiController]
	public class ErrorController : ControllerBase
	{
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		[Route("/error")]
		[HttpGet]
		[HttpPost]
		public IActionResult Error() => Problem();
	}
}

