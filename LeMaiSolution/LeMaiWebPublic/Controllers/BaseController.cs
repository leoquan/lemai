using ClosedXML.Excel;
using LeMaiDomain;
using LeMaiDomain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace LeMaiWebPublic.Controllers
{
	public class BaseController : Controller
	{
		protected readonly ILogger<BaseController> _logger;
		protected BaseController(ILogger<BaseController> logger)
		{
			this._logger = logger;
		}
		public string AtUserToken { get; set; }
		public override void OnActionExecuting(ActionExecutingContext context)
		{
			AtUserToken = GetAtUserToken();
			ViewBag.AtUserToken = AtUserToken;
			base.OnActionExecuting(context);
		}
		public override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
		{
			AtUserToken = GetAtUserToken();
			ViewBag.AtUserToken = AtUserToken;
			return base.OnActionExecutionAsync(context, next);
		}
		private string GetAtUserToken()
		{
			if (!User.Identity.IsAuthenticated)
			{
				return "";
			}
			return User.Claims.FirstOrDefault(h => h.Type == "AtUserToken")?.Value;
		}
		public string GetUserId()
		{
			if (!User.Identity.IsAuthenticated)
			{
				return "";
			}
			return User.Claims.FirstOrDefault(h => h.Type == "userId")?.Value;
		}
        public string GetPost()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return "";
            }
            return User.Claims.FirstOrDefault(h => h.Type == "post")?.Value;
        }
        public string GetFee()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return "";
            }
            return User.Claims.FirstOrDefault(h => h.Type == "FeeId")?.Value;
        }
        public string GetUserName()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return "";
            }
            return User.Claims.FirstOrDefault(h => h.Type == ClaimTypes.Name)?.Value;
        }
        protected string HandleException(Exception ex, bool addErrorToModelState)
		{
			var errorId = ExceptionHelpers.NewErrorId();
			_logger.LogError(ex, ExceptionHelpers.GetMessage(errorId, ex.Message));

			if (addErrorToModelState)
			{
				ModelState.AddModelError("", "Đã có lỗi xảy ra trong quá trình xử lý. Vui lòng liên hệ nhà quản trị với mã lỗi: " + errorId);
			}
			return errorId;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="data"></param>
		/// <returns></returns>
		protected static ActionResult<ApiResultDto<T>> CreateResult<T>(T data)
		{
			return new ActionResult<ApiResultDto<T>>(new ApiResultDto<T>(data));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="errorCode"></param>
		/// <returns></returns>
		protected static ActionResult<ApiResultDto<T>> CreateError<T>(ErrorCodeEnum errorCode)
		{
			return new ActionResult<ApiResultDto<T>>(new ApiResultDto<T>(default) { IsOk = false, ErrorCode = errorCode });
		}
        public byte[] ExportExcel(string fileTemplate, int indexSheet, DataTable data, Dictionary<string, string> listTitleID, Dictionary<string, string> listReplaceValue, Dictionary<string, string> format, bool includeSTT = true, List<string> listString = null)
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
	internal static class ExceptionHelpers
	{
		public static string NewErrorId()
		{
			return $"{DateTime.UtcNow.ToString("ddMMyy_HHmmss")}_{Guid.NewGuid().ToString().Substring(0, 8)}";
		}

		public static string GetMessage(in string errorId, in string message)
		{
			return $"Error Id: {errorId} | {message}";
		}
	}
    
}

