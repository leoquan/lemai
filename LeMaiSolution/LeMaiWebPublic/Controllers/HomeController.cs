using LeMaiDomain.Models;
using LeMaiLogic;
using LeMaiLogic.Logic;
using LeMaiWebPublic.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LeMaiWebPublic.Controllers
{
    public class HomeController : BaseController
    {
        BaseLogicConnectionData dataConnection = new BaseLogicConnectionData();
        private WebsiteUserLogic _logic;
        private GExpBillLogic _logicBill;
        private string branchCode = string.Empty;
        public HomeController(ILogger<HomeController> logger, IConfiguration configuration) : base(logger)
        {
            dataConnection.ConnectionString = configuration.GetConnectionString("DefaultConnection");
            dataConnection.Schema = "dbo";
            _logic = new WebsiteUserLogic(dataConnection);
            _logicBill = new GExpBillLogic(dataConnection);
            branchCode = configuration.GetValue<String>("ClientKey");
        }

        public async Task<IActionResult> Index([FromQuery] string code, [FromQuery] string lang)
        {
            if (string.IsNullOrEmpty(code))
            {
                var model = new WebHomeIndexModel();
                model.display = "display:none";
                model.displayInfo = "display:none";
                ViewData["webconfig"] = WebOptionHelper.ReadWebOption(dataConnection.ConnectionString, dataConnection.Schema, branchCode);
                return View(model);
            }
            else
            {
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
        [Route("Privacy")]
        public IActionResult Privacy()
        {
            ViewData["webconfig"] = WebOptionHelper.ReadWebOption(dataConnection.ConnectionString, dataConnection.Schema, branchCode);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [Route("gioi-thieu")]
        public IActionResult About()
        {
            ViewData["webconfig"] = WebOptionHelper.ReadWebOption(dataConnection.ConnectionString, dataConnection.Schema, branchCode);
            return View();
        }
        [Route("lien-he")]
        public IActionResult Contact()
        {
            ViewData["webconfig"] = WebOptionHelper.ReadWebOption(dataConnection.ConnectionString, dataConnection.Schema, branchCode);
            return View();
        }
    }
}
