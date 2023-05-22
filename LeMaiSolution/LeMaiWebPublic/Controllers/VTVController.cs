using LeMaiDomain.Models;
using LeMaiLogic;
using LeMaiLogic.Logic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace LeMaiWebPublic.Controllers
{
    public class VTVController : BaseController
	{
		BaseLogicConnectionData dataConnection = new BaseLogicConnectionData();
		private GExpBillLogic _logicBill;
        private string branchCode = string.Empty;
        public VTVController(ILogger<HomeController> logger, IConfiguration configuration) : base(logger)
		{
			dataConnection.ConnectionString = configuration.GetConnectionString("DefaultConnection");
			dataConnection.Schema = "dbo";
			_logicBill = new GExpBillLogic(dataConnection);
            branchCode = configuration.GetValue<String>("ClientKey");
        }
		public async Task<IActionResult> Index([FromQuery] string code, [FromQuery] string lang)
		{
			if (string.IsNullOrEmpty(code))
			{
                ViewData["tracuulable"] = "Tra cứu đơn hàng";
                var model = new WebHomeIndexModel();
				model.display = "display:none";
				model.displayInfo = "display:none";
				ViewData["webconfig"] = WebOptionHelper.ReadWebOption(dataConnection.ConnectionString, dataConnection.Schema, branchCode);
                return View(model);
			}
			else
			{
                ViewData["tracuulable"] = string.Empty;
                var model = new WebHomeIndexModel();
				ViewData["webconfig"] = WebOptionHelper.ReadWebOption(dataConnection.ConnectionString, dataConnection.Schema, branchCode);
                model.message = "Chi tiết hành trình";
				model.billCode = code;
				model.listTracking = await _logicBill.GetListTrack(code);
				if (model.listTracking.Count == 0)
				{
					model.displayInfo = "display:none";
					model.message = "Không tìm thấy đơn hàng [" + code + "]";
				}
				else
				{
					model.AcceptMan = model.listTracking[0].AcceptMan;
					model.AcceptManPhone = model.listTracking[0].AcceptManPhone;
					model.GoodsName = model.listTracking[0].GoodsName;
					model.BillWeight = model.listTracking[0].FeeWeight;
					if (model.listTracking[0].FK_PaymentType == "NTT")
					{
						model.COD = model.listTracking[0].COD;
						model.Freight = model.listTracking[0].Freight;
						model.Total = model.COD + model.Freight;
					}
					else
					{
						model.COD = model.listTracking[0].COD;
						model.Freight = model.listTracking[0].Freight;
						model.Total = model.COD;
						model.COD = model.COD - model.Freight;

					}


				}
				return View(model);
			}
		}
		[HttpPost]
		public async Task<IActionResult> Index(string code)
		{
			var model = new WebHomeIndexModel();
			ViewData["webconfig"] = WebOptionHelper.ReadWebOption(dataConnection.ConnectionString, dataConnection.Schema, branchCode);
            model.message = "Chi tiết hành trình";
			model.billCode = code;
			model.listTracking = await _logicBill.GetListTrack(code);
			ViewData["tracuulable"] = string.Empty;

            if (model.listTracking.Count == 0)
			{
                model.displayInfo = "display:none";
				model.message = "Không tìm thấy đơn hàng [" + code + "]";
			}
			else
			{
				model.AcceptMan = model.listTracking[0].AcceptMan;
				model.AcceptManPhone = model.listTracking[0].AcceptManPhone;
				model.GoodsName = model.listTracking[0].GoodsName;
				model.BillWeight = model.listTracking[0].FeeWeight;
				if (model.listTracking[0].FK_PaymentType == "NTT")
				{
					model.COD = model.listTracking[0].COD;
					model.Freight = model.listTracking[0].Freight;
					model.Total = model.COD + model.Freight;
				}
				else
				{
					model.COD = model.listTracking[0].COD;
					model.Freight = model.listTracking[0].Freight;
					model.Total = model.COD;
					model.COD = model.COD - model.Freight;
				}


			}
			return View(model);
		}

		[Route("chinh-sach-bao-mat")]
		public IActionResult Privacy()
		{
			ViewData["webconfig"] = WebOptionHelper.ReadWebOption(dataConnection.ConnectionString, dataConnection.Schema, branchCode);
            return View();
		}
	}
}
