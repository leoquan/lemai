using ClosedXML.Excel;
using LeMaiDomain;
using LeMaiDomain.Models;
using LeMaiLogic;
using LeMaiLogic.Logic;
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
        private GExpBillLogic _logicbill;
        public PCustomerController(ILogger<POrderController> logger, IConfiguration configuration) : base(logger)
        {
            dataConnection.ConnectionString = configuration.GetConnectionString("DefaultConnection");
            dataConnection.Schema = "dbo";
            _logicbill = new GExpBillLogic(dataConnection);

        }
        /// <summary>
        /// Danh sách
        /// </summary>
        /// <returns></returns>
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
        [HttpPost]
        public async Task<IActionResult> CreateUpdate([FromBody] BaseFilter input)
        {

            return View();
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
            byte[] fileArray = Export("TEMP.xlsx", 1, dtable, lsTitile, lsReplace, format, true, lsKeyString);
            var bytesdata = File(fileArray, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
            return Json(Convert.ToBase64String(fileArray, 0, fileArray.Length));
        }
        public byte[] Export(string fileTemplate, int indexSheet, DataTable data, Dictionary<string, string> listTitleID, Dictionary<string, string> listReplaceValue, Dictionary<string, string> format, bool includeSTT = true, List<string> listString = null)
        {
            try
            {
                if (data.Rows.Count <= 0)
                {
                    return null;
                }
                string templateFileName = AppDomain.CurrentDomain.BaseDirectory + "wwwroot\\Templates\\" + fileTemplate;

                if (listString == null)
                {
                    listString = new List<string>();
                }
                // Khởi tạo WorkBook
                var workBook = new XLWorkbook(templateFileName);
                var workSheet = workBook.Worksheet(indexSheet);
                // Step 1 - Thay đổi giá trị của các từ khóa  dạng {KEY} thành giá trị trong dictionary
                foreach (var item in listReplaceValue)
                {
                    string key = "{" + item.Key + "}";
                    IXLCells cells = workSheet.CellsUsed(c => c.GetString().Contains(key));
                    foreach (var cell in cells)
                    {
                        cell.Value = cell.Value.ToString().Replace(key, item.Value);
                    }
                }
                // Step 2 - Thêm các cột dữ liệu khác #data vào file mẫu nếu có.
                var cellColumName = workSheet.CellsUsed(c => c.GetString() == TemplateKey.KEY_COLUMN_NAME).FirstOrDefault();
                if (cellColumName == null)
                {
                    return null;
                }
                var cellEndColumName = workSheet.CellsUsed(c => c.GetString() == TemplateKey.KEY_END_COLUMN_NAME).FirstOrDefault();
                if (cellEndColumName == null)
                {
                    return null;
                }
                var cellHeader = workSheet.CellsUsed(c => c.GetString() == TemplateKey.KEY_HEADER).FirstOrDefault();
                if (cellHeader == null)
                {
                    return null;
                }
                bool haveAutoGen = true;
                var cellColum = workSheet.CellsUsed(c => c.GetString() == TemplateKey.KEY_COLUMN).FirstOrDefault();
                if (cellColum == null)
                {
                    haveAutoGen = false;
                }
                var cellColumTitle = workSheet.CellsUsed(c => c.GetString() == TemplateKey.KEY_COLUMN_TITLE).FirstOrDefault();
                if (cellColumTitle == null)
                {
                    haveAutoGen = false;
                }
                var cellRow = workSheet.CellsUsed(c => c.GetString() == TemplateKey.KEY_ROW).FirstOrDefault();
                if (cellRow == null)
                {
                    return null;
                }
                IXLRow rowColumName = workSheet.Row(cellColumName.Address.RowNumber);

                // Xử lý thêm các colum theo cấu trúc DataTable
                if (haveAutoGen)
                {
                    IXLColumn columData = workSheet.Column(cellColum.Address.ColumnNumber);

                    foreach (DataColumn item in data.Columns)
                    {
                        var cellCheck = rowColumName.CellsUsed(c => c.GetString() == item.ColumnName).SingleOrDefault();
                        if (cellCheck == null)
                        {
                            // column của DataTable chưa được định nghĩa dữ liệu.
                            // Thêm column vào
                            IXLColumn newColumnData = columData.InsertColumnsAfter(1).FirstOrDefault();
                            newColumnData.Cell(cellColumName.Address.RowNumber).Value = item.ColumnName;
                            if (listTitleID.ContainsKey(item.ColumnName))
                            {
                                newColumnData.Cell(cellColumTitle.Address.RowNumber).Value = listTitleID[item.ColumnName];
                            }
                            else
                            {
                                newColumnData.Cell(cellColumTitle.Address.RowNumber).Value = item.ColumnName;
                            }
                        }
                    }
                    // Thêm xong thì xóa cái cột template đi
                    columData.Delete();
                }

                cellEndColumName = workSheet.CellsUsed(c => c.GetString() == TemplateKey.KEY_END_COLUMN_NAME).FirstOrDefault();
                // Step 3 - Copy dữ liệu dòng dữ liệu và format
                IXLRow currentRow = workSheet.Row(cellRow.Address.RowNumber);
                // Insert các dòng dữ liệu
                currentRow.InsertRowsBelow(data.Rows.Count);
                // Fill data
                if (includeSTT)
                {
                    int rowNumber = currentRow.RowNumber();
                    int count = 1;
                    foreach (DataRow item in data.Rows)
                    {
                        // Fill data
                        IXLRow row = workSheet.Row(rowNumber);
                        // Colum STT
                        row.Cell(cellColumName.Address.ColumnNumber).Value = count;
                        int begin = cellColumName.Address.ColumnNumber + 1;
                        int end = cellEndColumName.Address.ColumnNumber;
                        for (int i = begin; i < end; i++)
                        {
                            string name = rowColumName.Cell(i).Value.ToString();
                            if (data.Columns.Contains(name))
                            {
                                string value = item[name].ToString();
                                if (format.ContainsKey(name))
                                {
                                    value = string.Format(format[name], item[name]);
                                }
                                if (listString.Exists(u => u == name))
                                {
                                    value = "'" + value;
                                }
                                if (string.IsNullOrEmpty(value))
                                {
                                    value = "'";
                                }
                                row.Cell(i).Value = value;
                            }
                        }
                        // Tăng index lên
                        rowNumber++;
                        count++;
                    }
                    // Clean
                    cellHeader.Value = "STT";
                    IXLRow deleteRow = workSheet.Row(cellColumName.Address.RowNumber);
                    deleteRow.Delete();
                }
                else
                {
                    // Không có cột STT dữ liệu
                    int rowNumber = currentRow.RowNumber();
                    int count = 1;
                    foreach (DataRow item in data.Rows)
                    {
                        // Fill data
                        IXLRow row = workSheet.Row(rowNumber);
                        // Colum STT
                        row.Cell(cellColumName.Address.ColumnNumber).Value = count;
                        int begin = cellColumName.Address.ColumnNumber + 1;
                        int end = cellEndColumName.Address.ColumnNumber;
                        for (int i = begin; i < end; i++)
                        {
                            string name = rowColumName.Cell(i).Value.ToString();
                            if (data.Columns.Contains(name))
                            {
                                string value = item[name].ToString();
                                if (format.ContainsKey(name))
                                {
                                    value = string.Format(format[name], item[name]);
                                }
                                if (listString.Exists(u => u == name))
                                {
                                    value = "'" + value;
                                }
                                if (string.IsNullOrEmpty(value))
                                {
                                    value = "'";
                                }
                                row.Cell(i).Value = value;
                            }
                        }
                        // Tăng index lên
                        rowNumber++;
                        count++;
                    }
                    // Clean
                    cellHeader.Value = "STT";
                    IXLColumn STT = workSheet.Column(cellHeader.Address.ColumnNumber);
                    STT.Delete();
                    IXLRow deleteRow = workSheet.Row(cellColumName.Address.RowNumber);
                    deleteRow.Delete();
                }

                // Save to disk
                using (MemoryStream stream = new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    return stream.ToArray();
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
