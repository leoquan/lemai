using LeMaiDomain;
using LeMaiLogic;
using LeMaiLogic.Logic;
using LeMaiModelWebApi.Order;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeMaiWebPublic.Controllers
{
    public class PAccountController : BaseController
    {
        BaseLogicConnectionData dataConnection = new BaseLogicConnectionData();
        private GExpBillLogic _logicbill;
        public PAccountController(ILogger<POrderController> logger, IConfiguration configuration) : base(logger)
        {
            dataConnection.ConnectionString = configuration.GetConnectionString("DefaultConnection");
            dataConnection.Schema = "dbo";
            _logicbill = new GExpBillLogic(dataConnection);

        }
        public IActionResult Index()
        {
            BaseBillFilter model = new BaseBillFilter();
            var lsStatus = _logicbill.GetGExpBillStatusAndAll();
            model.ListStatus = lsStatus.Select(h => new BaseStatusFilter { Value = h.Id.ToString(), Name = h.StatusName }).ToList();
            model.FromDate = string.Format("{0:yyyy-MM-dd}", DateTime.Now.AddDays(-7));
            model.Status = "-1";
            model.ToDate = string.Format("{0:yyyy-MM-dd}", DateTime.Now);

            model.ListBill = new List<view_GExpBill>();
            return View(model);
        }
    }
}