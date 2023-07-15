using ClosedXML.Excel;
using LeMaiDomain;
using LeMaiDomain.Models;
using LeMaiLogic;
using LeMaiLogic.Logic;
using LeMaiModelWebApi.Customer;
using LeMaiModelWebApi.Order;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace LeMaiWebPublic.Controllers
{
    public class PCustomerController : BaseController
    {
        BaseLogicConnectionData dataConnection = new BaseLogicConnectionData();
        //TODO: LOGIC
        private GExpBillLogic _logicbill;
        private CustomerLogic _logic;
        public PCustomerController(ILogger<POrderController> logger, IConfiguration configuration) : base(logger)
        {
            dataConnection.ConnectionString = configuration.GetConnectionString("DefaultConnection");
            dataConnection.Schema = "dbo";
            _logicbill = new GExpBillLogic(dataConnection);
            _logic= new CustomerLogic(dataConnection);
        }
        /// <summary>
        /// Danh sách
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index()
        {
            BaseCustomerFilter model = new BaseCustomerFilter();
            string userId = GetUserId();
            if (string.IsNullOrEmpty(userId))
            {
                return RedirectToAction("DangNhap", "POrder");
            }
            string postId = GetPost();

            var lsStatus = _logic.GetListFee(postId);
            model.ListStatus = lsStatus.Select(h => new BaseStatusFilter { Value = h.Id.ToString(), Name = h.FeeName }).ToList();
            model.FromDate = string.Format("{0:yyyy-MM-dd}", DateTime.Now.AddDays(-7));
            model.Status = "-1";
            model.ToDate = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
            model.KeySearch = string.Empty;
            model.ListCustomer = await _logic.GetList(model.KeySearch, postId);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Index(BaseFilter input)
        {
            BaseCustomerFilter model = new BaseCustomerFilter();
            string userId = GetUserId();
            if (string.IsNullOrEmpty(userId))
            {
                return RedirectToAction("DangNhap", "POrder");
            }
            string postId = GetPost();

            var lsStatus = _logic.GetListFee(postId);
            model.ListStatus = lsStatus.Select(h => new BaseStatusFilter { Value = h.Id.ToString(), Name = h.FeeName }).ToList();
            model.FromDate = string.Format("{0:yyyy-MM-dd}", DateTime.Now.AddDays(-7));
            model.Status = "-1";
            model.ToDate = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
            model.KeySearch = input.KeySearch;
            model.ListCustomer = await _logic.GetList(model.KeySearch, postId);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(string Id)
        {
            BaseOutput result = new BaseOutput();
            result.Code = 200;
            return Json(result);
        }
        [HttpPost]
        public async Task<IActionResult> GetDetail(string Id)
        {
            BaseOutput result = new BaseOutput();
            result.Code = 0;
            result.Error = "Lỗi xóa dữ liệu, vui lòng liên hệ quản trị";
            return Json(result);
        }
        [HttpPost]
        public async Task<IActionResult> CreateUpdate([FromBody] CreateCustomerInput input)
        {
            if (input == null)
            {
                return BadRequest();
            }
            BaseOutput result = new BaseOutput();
            return Json(result);
        }

        [HttpPost]
        public async Task<IActionResult> Export([FromBody] BaseFilter input)
        {
            string userId = GetUserId();
            if (input.FromDate == null)
            {
                input.FromDate = string.Format("{0:yyyy-MM-dd}", DateTime.Now.AddDays(-7));
            }

            if (input.ToDate == null)
            {
                input.ToDate = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
            }
            //var listData = await _logicbill.GetBillList(userId, input.datefrom, input.dateto, input.status);
            var listData = new List<string>();// Logic fill ở đây
            DataTable dtable = MapperExtensionClass.ToDataTable(listData);
            Dictionary<string, string> lsReplace = new Dictionary<string, string>();
            Dictionary<string, string> format = new Dictionary<string, string>();
            //format.Add("RegisterDate", "{0:dd/MM/yyyy HH:mm}");
            Dictionary<string, string> lsTitile = new Dictionary<string, string>();
            List<string> lsKeyString = new List<string>();
            //lsKeyString.Add("BillCode");
            byte[] fileArray = ExportExcel("TEMP.xlsx", 1, dtable, lsTitile, lsReplace, format, true, lsKeyString);
            var bytesdata = File(fileArray, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
            return Json(Convert.ToBase64String(fileArray, 0, fileArray.Length));
        }
        
    }
}
