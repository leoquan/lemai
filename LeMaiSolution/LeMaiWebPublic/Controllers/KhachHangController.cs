using ClosedXML.Excel;
using LeMaiDomain;
using LeMaiDomain.Models;
using LeMaiLogic;
using LeMaiLogic.Logic;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
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
    public class KhachHangController : BaseController
    {
        BaseLogicConnectionData dataConnection = new BaseLogicConnectionData();
        private WebsiteKhachHangLogic _logic;
        private GExpBillLogic _logicbill;
        private string branchCode = string.Empty;
        public KhachHangController(ILogger<KhachHangController> logger, IConfiguration configuration) : base(logger)
        {
            dataConnection.ConnectionString = configuration.GetConnectionString("DefaultConnection");
            dataConnection.Schema = "dbo";
            _logic = new WebsiteKhachHangLogic(dataConnection);
            _logicbill = new GExpBillLogic(dataConnection);
            branchCode = configuration.GetValue<String>("ClientKey");
        }
        public async Task<IActionResult> Index()
        {
            
            string userId = GetUserId();
            ViewData["loginName"] = GetUserName();
            ViewData["webconfig"] = WebOptionHelper.ReadWebOption(dataConnection.ConnectionString, dataConnection.Schema, branchCode);
            WebKhachHangIndexModel model = new WebKhachHangIndexModel();
            var total = await _logicbill.GetAllTotalReport(userId);
            if (total == null)
            {
                total = new LeMaiDomain.view_SumGExpBill();
                total.COD_DATT = 0;
                total.FK_Customer = userId;
                total.SODON = 0;
                total.COD_CHUATT = 0;
                total.TONGTIEN = 0;
            }
            model.ChuaThanhToan = (decimal)total.COD_CHUATT;
            model.DaThanhToan = (decimal)total.COD_DATT;
            model.SoDon = (int)total.SODON;
            model.TongTien = (decimal)total.TONGTIEN;

            model.MaxGiaoThanhCong = 100;
            model.MaxSanLuong = 500;

            var listBill = await _logicbill.GetListTotalStatus(userId);
            var listSanLuong = await _logicbill.GetListTotalSanLuong(userId);
            var listKyNhan = await _logicbill.GetListTotalKyNhan(userId);
            if (listSanLuong.Count > 0)
            {
                model.MaxSanLuong = (int)listSanLuong.Max(u => u.COUNT_TT);
            }

            if (listKyNhan.Count > 0)
            {
                model.MaxGiaoThanhCong = (int)listKyNhan.Max(u => u.COUNT_TT);
            }
            model.MaxGiaoThanhCong = model.MaxGiaoThanhCong + (model.MaxGiaoThanhCong / 10);
            model.MaxSanLuong = model.MaxSanLuong + (model.MaxSanLuong / 10);

            model.ChartCOD = new List<DataChart>();
            DataChart t = new DataChart();
            t.NameStatus = "Chưa thanh toán";
            t.SoLuong = (int)model.ChuaThanhToan;
            t.ColorStatus = "red";
            model.ChartCOD.Add(t);
            t = new DataChart();
            t.NameStatus = "Đã thanh toán";
            t.SoLuong = (int)model.DaThanhToan;
            t.ColorStatus = "green";
            model.ChartCOD.Add(t);

            model.ChartBill = new List<DataChart>();
            foreach (var item in listBill)
            {
                DataChart chart = new DataChart();
                chart.NameStatus = item.StatusName;
                chart.SoLuong = (int)item.COUNT_TT;
                chart.ColorStatus = item.StatusBackgroundColor;
                model.ChartBill.Add(chart);
            }

            model.ChartSanLuong = new List<DataChart>();
            foreach (var item in listSanLuong)
            {
                DataChart chart = new DataChart();
                chart.NameStatus = string.Format("{0:dd/MM/yyyy}", item.DATE_TT);
                chart.SoLuong = (int)item.COUNT_TT;
                chart.ColorStatus = string.Empty;
                model.ChartSanLuong.Add(chart);
            }

            model.ChartGiaoThanhCong = new List<DataChart>();
            foreach (var item in listKyNhan)
            {
                DataChart chart = new DataChart();
                chart.NameStatus = string.Format("{0:dd/MM/yyyy}", item.DATE_TT);
                chart.SoLuong = (int)item.COUNT_TT;
                chart.ColorStatus = string.Empty;
                model.ChartGiaoThanhCong.Add(chart);
            }

            return View(model);
        }
        //[Route("khach-hang")]
        public IActionResult Login()
        {
            ViewData["webconfig"] = WebOptionHelper.ReadWebOption(dataConnection.ConnectionString, dataConnection.Schema, branchCode);
            string userId = GetUserId();
            if (!string.IsNullOrEmpty(userId))
            {
                return RedirectToAction("Index", "KhachHang");
            }
            return View();
        }
        [HttpPost]
        //[Route("khach-hang")]
        public async Task<IActionResult> Login(string customerCode, string customerPass)
        {
            ViewData["webconfig"] = WebOptionHelper.ReadWebOption(dataConnection.ConnectionString, dataConnection.Schema, branchCode);
            var profileAccount = await _logic.LoginCustomer(customerCode, customerPass);
            if (profileAccount == null)
            {
                ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không đúng !");
                ViewBag.ShowErros = "Tên đăng nhập hoặc mật khẩu không đúng !";
                return View("Login");
            }
            var claims = new List<Claim>
                            {
                            new Claim(ClaimTypes.Name, profileAccount.CustomerName),
                            new Claim("userId", profileAccount.Id),
                            new Claim("post", profileAccount.FK_Post),
                            new Claim("FeeId", profileAccount.FK_GiaCuoc)
                            };
            var claimsIdentity = new ClaimsIdentity(
                claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties
            {
            };
            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
            new ClaimsPrincipal(claimsIdentity), authProperties);
            return RedirectToAction("Index", "KhachHang");
        }
        public async Task<IActionResult> Logout()
        {
            ViewData["webconfig"] = WebOptionHelper.ReadWebOption(dataConnection.ConnectionString, dataConnection.Schema, branchCode);
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
        public IActionResult ChangePass()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ChangePass(string oldPass, string newPass, string rePass)
        {
            ViewData["webconfig"] = WebOptionHelper.ReadWebOption(dataConnection.ConnectionString, dataConnection.Schema, branchCode);
            string userId = GetUserId();
            if (newPass != rePass)
            {
                ViewBag.ShowErros = "Mật khẩu và xác nhận mật khẩu không đúng!";
                return View();
            }
            string result = await _logic.ChangePassCustomer(oldPass, newPass, userId);
            if (string.IsNullOrEmpty(result))
            {
                return View("Index");
            }
            else
            {
                ViewBag.ShowErros = result;
                return View();
            }
        }

        public async Task<IActionResult> Bills()
        {
            
            WebKhachHangBillModel model = new WebKhachHangBillModel();
            string userId = GetUserId();
            ViewData["loginName"] = GetUserName();
            ViewData["webconfig"] = WebOptionHelper.ReadWebOption(dataConnection.ConnectionString, dataConnection.Schema, branchCode);
            model.dateFrom = string.Format("{0:yyyy-MM-dd}", DateTime.Now.AddDays(-7));
            model.status = -1;
            model.dateTo = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
            model.listBillStatus = await _logic.GetBillStatusList();
            model.ListBill = await _logic.GetBillList(userId, model.dateFrom, model.dateTo, -1);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Bills(string datefrom, string dateto, int status)
        {
            
            WebKhachHangBillModel model = new WebKhachHangBillModel();
            string userId = GetUserId();
            if (datefrom == null)
            {
                datefrom = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
            }
            if (dateto == null)
            {
                dateto = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
            }
            ViewData["loginName"] = GetUserName();
            ViewData["webconfig"] = WebOptionHelper.ReadWebOption(dataConnection.ConnectionString, dataConnection.Schema, branchCode);
            model.dateFrom = datefrom;
            model.status = status;
            model.dateTo = dateto;
            model.listBillStatus = await _logic.GetBillStatusList();
            model.ListBill = await _logic.GetBillList(userId, datefrom, dateto, status);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> ExportBills([FromBody] JsonFilterInput input)
        {
            string userId = GetUserId();
            if (input.datefrom == null)
            {
                input.datefrom = string.Format("{0:yyyy-MM-dd}", DateTime.Now.AddDays(-7));
            }

            if (input.dateto == null)
            {
                input.dateto = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
            }
            var listData = await _logic.GetBillList(userId, input.datefrom, input.dateto, input.status);
            DataTable dtable = MapperExtensionClass.ToDataTable(listData);
            Dictionary<string, string> lsReplace = new Dictionary<string, string>();
            Dictionary<string, string> format = new Dictionary<string, string>();
            format.Add("RegisterDate", "{0:dd/MM/yyyy HH:mm}");
            Dictionary<string, string> lsTitile = new Dictionary<string, string>();
            List<string> lsKeyString = new List<string>();
            lsKeyString.Add("BillCode");
            lsKeyString.Add("RegisterDate");
            lsKeyString.Add("SendManPhone");
            lsKeyString.Add("AcceptManPhone");
            byte[] fileArray = Export("MAU_XUAT_DON.xlsx", 1, dtable, lsTitile, lsReplace, format, true, lsKeyString);
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
                string templateFileName = AppDomain.CurrentDomain.BaseDirectory + "wwwroot\\" + fileTemplate;

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
        public async Task<IActionResult> BillDetail(string BillCode, string backAction)
        {
            WebKhachHangBillDetailModel model = new WebKhachHangBillDetailModel();
            ViewData["loginName"] = GetUserName();
            ViewData["webconfig"] = WebOptionHelper.ReadWebOption(dataConnection.ConnectionString, dataConnection.Schema, branchCode);
            model.Bill = await _logicbill.GetDetails(BillCode);
            model.scanList = await _logicbill.GetListTrack(BillCode);
            model.backAction = backAction;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> GetCalculator(string IdTinh, string IdHuyen, int? Weight)
        {
            string w = Weight == null ? "0" : Weight.ToString();
            string post = GetPost();
            string FeeId = GetFee();
            string result = await _logicbill.GetCalculatorFee(w, FeeId, IdTinh, post, IdHuyen);
            return Json(result);
        }

        [HttpPost]
        public async Task<IActionResult> GetHuyen(string IdTinh)
        {
            HuyenXaModel model = new HuyenXaModel();
            model.dist = await _logic.GetDanhSachHuyen(IdTinh);
            model.ward = await _logic.GetDanhSachXa(model.dist[0].DistrictID.ToString());
            return Json(model);
        }
        [HttpPost]
        public async Task<IActionResult> GetXa(string IdHuyen)
        {
            var XaList = await _logic.GetDanhSachXa(IdHuyen);
            return Json(XaList);
        }
        public async Task<IActionResult> CreateOrder(string OrderCode, string CustomerId)
        {
            ViewData["webconfig"] = WebOptionHelper.ReadWebOption(dataConnection.ConnectionString, dataConnection.Schema, branchCode);
            ViewData["loginName"] = GetUserName();
            WebKhachHangOrderModel model = new WebKhachHangOrderModel();

            if (!string.IsNullOrEmpty(OrderCode) && !string.IsNullOrEmpty(CustomerId))
            {
                // Load Order
                model.OrderDetail = await _logic.GetOrderDetail(CustomerId, OrderCode);
                model.ProvinderList = await _logic.GetDanhSachTinh();
                model.ProvinceCodeSelect = (int)model.OrderDetail.ProvinceCode;

                model.DistrictList = await _logic.GetDanhSachHuyen(model.ProvinceCodeSelect.ToString());
                model.DistrictCodeSelect = (int)model.OrderDetail.DistrictCode;

                model.WardList = await _logic.GetDanhSachXa(model.DistrictCodeSelect.ToString());
                model.WardCodeSelect = model.OrderDetail.DistrictWard;
            }
            else
            {
                // Không có order
                model.ProvinderList = await _logic.GetDanhSachTinh();
                model.ProvinceCodeSelect = model.ProvinderList[0].ProvinceID;

                model.DistrictList = await _logic.GetDanhSachHuyen(model.ProvinceCodeSelect.ToString());
                model.DistrictCodeSelect = model.DistrictList[0].DistrictID;

                model.WardList = await _logic.GetDanhSachXa(model.DistrictCodeSelect.ToString());
                model.WardCodeSelect = model.WardList[0].WardId;

                model.OrderDetail = new LeMaiDomain.view_GExpOrder();
                model.OrderDetail.OrderCode = string.Format("{0:yyMMddHHmmssf}", DateTime.Now);
            }
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> CreateOrder(string OrderCode, string AcceptName, string AcceptPhone, string AcceptAddress, string Ward, string District, string Province,
            string GoodsName, decimal? COD, int? Weight, bool IsShopPay, string Note)
        {
            WebKhachHangOrderModel model = new WebKhachHangOrderModel();
            // Init model
            model.OrderDetail = new LeMaiDomain.view_GExpOrder();
            model.OrderDetail.OrderCode = OrderCode;
            model.OrderDetail.AcceptPhone = AcceptPhone;
            model.OrderDetail.AcceptName = AcceptName;
            model.OrderDetail.AcceptAddress = AcceptAddress;
            model.OrderDetail.GoodsName = GoodsName;

            model.ProvinderList = await _logic.GetDanhSachTinh();
            model.ProvinceCodeSelect = Int32.Parse(Province);

            model.DistrictList = await _logic.GetDanhSachHuyen(model.ProvinceCodeSelect.ToString());
            model.DistrictCodeSelect = Int32.Parse(District);

            model.WardList = await _logic.GetDanhSachXa(model.DistrictCodeSelect.ToString());
            model.WardCodeSelect = Ward;

            model.OrderDetail.IsShopPay = IsShopPay;
            model.OrderDetail.Note = Note;
            // check input
            if (string.IsNullOrEmpty(AcceptName))
            {
                model.ErrorMessage = "Tên người nhận không được trống.";
                return View(model);
            }
            if (string.IsNullOrEmpty(AcceptPhone))
            {
                model.ErrorMessage = "Điện thoại nhận không được trống.";
                return View(model);
            }
            if (string.IsNullOrEmpty(AcceptAddress))
            {
                model.ErrorMessage = "Địa chỉ người nhận không được trống.";
                return View(model);
            }
            if (string.IsNullOrEmpty(GoodsName))
            {
                model.ErrorMessage = "Tên hàng hóa không được trống.";
                return View(model);
            }
            decimal cod = 0;
            if (COD == null)
            {
                cod = 0;
            }
            else
            {
                cod = (decimal)COD;
            }
            int weight = 0;
            if (Weight == null)
            {
                weight = 0;
            }
            else
            {
                weight = (int)Weight;
            }
            model.OrderDetail.COD = cod;
            model.OrderDetail.Weight = weight;

            string userId = GetUserId();
            string result = await _logic.CreateOrUpDateOrder(userId, OrderCode, AcceptName, AcceptPhone, AcceptAddress,
             GoodsName, cod, weight, IsShopPay, Note, Province, District, Ward);
            if (string.IsNullOrEmpty(result))
            {
                // Tạo hoặc update thành công
                return RedirectToAction("Orders", "KhachHang");
            }
            else
            {
                // Thao tác thất bại
                model.ErrorMessage = result;
                return View(model);
            }
        }
        public async Task<IActionResult> Orders()
        {
            WebKhachHangBillModel model = new WebKhachHangBillModel();
            string userId = GetUserId();
            ViewData["loginName"] = GetUserName();
            ViewData["webconfig"] = WebOptionHelper.ReadWebOption(dataConnection.ConnectionString, dataConnection.Schema, branchCode);
            model.dateFrom = string.Format("{0:yyyy-MM-dd}", DateTime.Now.AddDays(-7));
            model.status = -1;
            model.customerId = userId;
            model.dateTo = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
            model.listOrderStatus = await _logic.GetOrderStatusList();
            model.ListOrder = await _logic.GetOrderList(userId, model.dateFrom, model.dateTo, -1);
            return View(model);
        }
        [HttpPost]
        [RequestFormLimits(ValueLengthLimit = int.MaxValue, MultipartBodyLengthLimit = int.MaxValue)]
        public async Task<IActionResult> ExcelOrder(IFormFile formFile)
        {
            string userId = GetUserId();
            if (formFile != null)
            {
                try
                {
                    var fileextension = Path.GetExtension(formFile.FileName);
                    var filename = Guid.NewGuid().ToString() + fileextension;
                    var filepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files", filename);
                    using (FileStream fs = System.IO.File.Create(filepath))
                    {
                        formFile.CopyTo(fs);
                    }
                    DataTable data = ExcelHelper.Read2007Xlsx(filepath);
                    try
                    {
                        //Delete file
                        System.IO.File.Delete(filepath);
                    }
                    catch
                    {
                    }
                    foreach (DataColumn col in data.Columns)
                    {
                        if (col.ColumnName.Contains("TÊN KH"))
                        {
                            col.ColumnName = "TEN_KH";
                        }
                        else if (col.ColumnName.Contains("SDT"))
                        {
                            col.ColumnName = "SDT";
                        }
                        else if (col.ColumnName.Contains("ĐỊA CHỈ"))
                        {
                            col.ColumnName = "DIA_CHI";
                        }
                        else if (col.ColumnName.Contains("TÊN SP"))
                        {
                            col.ColumnName = "TEN_SP";
                        }
                        else if (col.ColumnName.Contains("KHỐI LƯỢNG"))
                        {
                            col.ColumnName = "KHOI_LUONG";
                        }
                        else if (col.ColumnName.Contains("TIỀN COD"))
                        {
                            col.ColumnName = "COD";
                        }
                        else if (col.ColumnName.Contains("GHI CHÚ"))
                        {
                            col.ColumnName = "GHI_CHU";
                        }
                    }
                    string refixOrderCode = string.Format("{0:yyMMddHHmm}", DateTime.Now);
                    ExpCustomer customer = _logicbill.GetThongTinKhachHangById(userId);
                    int index = 0;
                    foreach (DataRow dr in data.Rows)
                    {
                        string AcceptPhone = dr["SDT"].ToString().Trim();
                        string AcceptAddress = dr["DIA_CHI"].ToString();
                        if (!string.IsNullOrEmpty(AcceptPhone) && !string.IsNullOrEmpty(AcceptAddress))
                        {
                            index++;
                            string OrderCode = refixOrderCode + index.ToString().PadLeft(3, '0');
                            string AcceptName = dr["TEN_KH"].ToString();
                            if (string.IsNullOrEmpty(AcceptName))
                            {
                                AcceptName = "Khách hàng";
                            }
                            string GoodsName = dr["TEN_SP"].ToString();
                            if (string.IsNullOrEmpty(GoodsName))
                            {
                                GoodsName = "Sản phẩm";
                            }
                            decimal cod = 0;
                            if (!decimal.TryParse(dr["COD"].ToString(), out cod))
                            {
                                cod = 0;
                            }
                            int weight = 0;
                            if (!int.TryParse(dr["KHOI_LUONG"].ToString(), out weight))
                            {
                                weight = 0;
                            }
                            weight = weight * 1000;

                            bool IsShopPay = true;
                            string Note = dr["GHI_CHU"].ToString();
                            if (string.IsNullOrEmpty(Note))
                            {
                                Note = "Vui lòng liên hệ số điện thoại " + customer.CustomerPhone + " khi đơn hàng có vấn đề hoặc khách không nhận hàng";
                            }
                            string Province = "0";
                            string District = "0";
                            string Ward = "";

                            string result = await _logic.CreateOrUpDateOrder(userId, OrderCode, AcceptName, AcceptPhone, AcceptAddress, GoodsName, cod, weight, IsShopPay, Note, Province, District, Ward);
                        }

                    }
                }
                catch (Exception)
                {

                }
            }


            // Load lại dữ liệu
            WebKhachHangBillModel model = new WebKhachHangBillModel();
            ViewData["webconfig"] = WebOptionHelper.ReadWebOption(dataConnection.ConnectionString, dataConnection.Schema, branchCode);
            ViewData["loginName"] = GetUserName();
            model.dateFrom = string.Format("{0:yyyy-MM-dd}", DateTime.Now.AddDays(-1));
            model.status = -1;
            model.customerId = userId;
            model.dateTo = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
            model.listOrderStatus = await _logic.GetOrderStatusList();
            model.ListOrder = await _logic.GetOrderList(userId, model.dateFrom, model.dateTo, -1);
            return View("Orders", model);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteOrder(string OrderId)
        {
            string userId = GetUserId();
            try
            {
                if (string.IsNullOrEmpty(OrderId))
                {
                    return Json(false);
                }
                else
                {
                    bool val = await _logic.DeleteOrder(OrderId);
                    return Json(val);
                }
            }
            catch
            {
                return Json(false);
            }


        }
        [HttpPost]
        public async Task<IActionResult> Orders(string datefrom, string dateto, int status)
        {
            WebKhachHangBillModel model = new WebKhachHangBillModel();
            string userId = GetUserId();
            if (datefrom == null)
            {
                datefrom = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
            }
            if (dateto == null)
            {
                dateto = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
            }
            ViewData["loginName"] = GetUserName();
            ViewData["webconfig"] = WebOptionHelper.ReadWebOption(dataConnection.ConnectionString, dataConnection.Schema, branchCode);
            model.dateFrom = datefrom;
            model.status = status;
            model.dateTo = dateto;
            model.customerId = userId;
            model.listOrderStatus = await _logic.GetOrderStatusList();
            model.ListOrder = await _logic.GetOrderList(userId, model.dateFrom, model.dateTo, status);
            return View(model);
        }
        public async Task<IActionResult> ExportOrders([FromBody] JsonFilterInput input)
        {
            string userId = GetUserId();
            if (input.datefrom == null)
            {
                input.datefrom = string.Format("{0:yyyy-MM-dd}", DateTime.Now.AddDays(-7));
            }

            if (input.dateto == null)
            {
                input.dateto = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
            }
            var listData = await _logic.GetOrderList(userId, input.datefrom, input.dateto, input.status);
            DataTable dtable = MapperExtensionClass.ToDataTable(listData);
            Dictionary<string, string> lsReplace = new Dictionary<string, string>();
            Dictionary<string, string> format = new Dictionary<string, string>();
            format.Add("CreateDate", "{0:dd/MM/yyyy HH:mm}");
            Dictionary<string, string> lsTitile = new Dictionary<string, string>();
            List<string> lsKeyString = new List<string>();
            lsKeyString.Add("OrderCode");
            lsKeyString.Add("CreateDate");
            lsKeyString.Add("AcceptPhone");
            byte[] fileArray = Export("MAU_XUAT_DON_ORDER.xlsx", 1, dtable, lsTitile, lsReplace, format, true, lsKeyString);
            var bytesdata = File(fileArray, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
            return Json(Convert.ToBase64String(fileArray, 0, fileArray.Length));
        }
        public async Task<IActionResult> PaidBills()
        {
            string userId = GetUserId();
            ViewData["loginName"] = GetUserName();
            ViewData["webconfig"] = WebOptionHelper.ReadWebOption(dataConnection.ConnectionString, dataConnection.Schema, branchCode);
            WebKhachHangBillModel model = new WebKhachHangBillModel();
            model.dateFrom = string.Format("{0:yyyy-MM-dd}", DateTime.Now.AddDays(-7));
            model.status = -1;
            model.dateTo = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
            model.ListBill = await _logic.GetPaidBillList(userId, model.dateFrom, model.dateTo);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> PaidBills(string datefrom, string dateto)
        {
            WebKhachHangBillModel model = new WebKhachHangBillModel();
            string userId = GetUserId();
            if (datefrom == null)
            {
                datefrom = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
            }
            if (dateto == null)
            {
                dateto = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
            }
            ViewData["loginName"] = GetUserName();
            ViewData["webconfig"] = WebOptionHelper.ReadWebOption(dataConnection.ConnectionString, dataConnection.Schema, branchCode);
            model.dateFrom = datefrom;
            model.dateTo = dateto;
            model.ListBill = await _logic.GetPaidBillList(userId, datefrom, dateto);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> ExportPaidBills([FromBody] JsonFilterInput input)
        {
            string userId = GetUserId();
            if (input.datefrom == null)
            {
                input.datefrom = string.Format("{0:yyyy-MM-dd}", DateTime.Now.AddDays(-7));
            }

            if (input.dateto == null)
            {
                input.dateto = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
            }
            var listData = await _logic.GetPaidBillList(userId, input.datefrom, input.dateto);
            DataTable dtable = MapperExtensionClass.ToDataTable(listData);
            Dictionary<string, string> lsReplace = new Dictionary<string, string>();
            Dictionary<string, string> format = new Dictionary<string, string>();
            format.Add("RegisterDate", "{0:dd/MM/yyyy HH:mm}");
            format.Add("PayCustomerDate", "{0:dd/MM/yyyy}");
            Dictionary<string, string> lsTitile = new Dictionary<string, string>();
            List<string> lsKeyString = new List<string>();
            lsKeyString.Add("BillCode");
            lsKeyString.Add("RegisterDate");
            lsKeyString.Add("SendManPhone");
            lsKeyString.Add("AcceptManPhone");
            lsKeyString.Add("PayCustomerDate");
            byte[] fileArray = Export("MAU_XUAT_DON_DATT.xlsx", 1, dtable, lsTitile, lsReplace, format, true, lsKeyString);
            var bytesdata = File(fileArray, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
            return Json(Convert.ToBase64String(fileArray, 0, fileArray.Length));
        }
        public async Task<IActionResult> UnPaidBills()
        {
            string userId = GetUserId();
            ViewData["loginName"] = GetUserName();
            ViewData["webconfig"] = WebOptionHelper.ReadWebOption(dataConnection.ConnectionString, dataConnection.Schema, branchCode);
            WebKhachHangBillModel model = new WebKhachHangBillModel();
            model.dateFrom = string.Format("{0:yyyy-MM-dd}", DateTime.Now.AddDays(-7));
            model.status = -1;
            model.dateTo = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
            model.ListBill = await _logic.GetUnPaidBillList(userId, model.dateFrom, model.dateTo);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> UnPaidBills(string datefrom, string dateto)
        {

            WebKhachHangBillModel model = new WebKhachHangBillModel();
            string userId = GetUserId();
            if (datefrom == null)
            {
                datefrom = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
            }
            if (dateto == null)
            {
                dateto = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
            }
            ViewData["loginName"] = GetUserName();
            ViewData["webconfig"] = WebOptionHelper.ReadWebOption(dataConnection.ConnectionString, dataConnection.Schema, branchCode);
            model.dateFrom = datefrom;
            model.dateTo = dateto;
            model.ListBill = await _logic.GetUnPaidBillList(userId, datefrom, dateto);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> ExportUnPaidBills([FromBody] JsonFilterInput input)
        {
            string userId = GetUserId();
            if (input.datefrom == null)
            {
                input.datefrom = string.Format("{0:yyyy-MM-dd}", DateTime.Now.AddDays(-7));
            }

            if (input.dateto == null)
            {
                input.dateto = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
            }
            var listData = await _logic.GetUnPaidBillList(userId, input.datefrom, input.dateto);
            DataTable dtable = MapperExtensionClass.ToDataTable(listData);
            Dictionary<string, string> lsReplace = new Dictionary<string, string>();
            Dictionary<string, string> format = new Dictionary<string, string>();
            format.Add("RegisterDate", "{0:dd/MM/yyyy HH:mm}");
            Dictionary<string, string> lsTitile = new Dictionary<string, string>();
            List<string> lsKeyString = new List<string>();
            lsKeyString.Add("BillCode");
            lsKeyString.Add("RegisterDate");
            lsKeyString.Add("SendManPhone");
            lsKeyString.Add("AcceptManPhone");
            byte[] fileArray = Export("MAU_XUAT_DON.xlsx", 1, dtable, lsTitile, lsReplace, format, true, lsKeyString);
            var bytesdata = File(fileArray, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
            return Json(Convert.ToBase64String(fileArray, 0, fileArray.Length));
        }
        public async Task<IActionResult> Problems()
        {
            string userId = GetUserId();
            ViewData["loginName"] = GetUserName();
            ViewData["webconfig"] = WebOptionHelper.ReadWebOption(dataConnection.ConnectionString, dataConnection.Schema, branchCode);
            WebKhachHangBillModel model = new WebKhachHangBillModel();
            model.dateFrom = string.Format("{0:yyyy-MM-dd}", DateTime.Now.AddDays(-7));
            model.status = -1;
            model.dateTo = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
            model.ListProblem = await _logic.GetProblemList(userId, model.dateFrom, model.dateTo);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Problems(string datefrom, string dateto)
        {
            WebKhachHangBillModel model = new WebKhachHangBillModel();
            string userId = GetUserId();
            if (datefrom == null)
            {
                datefrom = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
            }
            if (dateto == null)
            {
                dateto = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
            }
            ViewData["loginName"] = GetUserName();
            ViewData["webconfig"] = WebOptionHelper.ReadWebOption(dataConnection.ConnectionString, dataConnection.Schema, branchCode);
            model.dateFrom = datefrom;
            model.dateTo = dateto;
            model.ListProblem = await _logic.GetProblemList(userId, model.dateFrom, model.dateTo);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> ExportProblems([FromBody] JsonFilterInput input)
        {
            string userId = GetUserId();
            if (input.datefrom == null)
            {
                input.datefrom = string.Format("{0:yyyy-MM-dd}", DateTime.Now.AddDays(-7));
            }

            if (input.dateto == null)
            {
                input.dateto = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
            }
            var listData = await _logic.GetProblemList(userId, input.datefrom, input.dateto);
            DataTable dtable = MapperExtensionClass.ToDataTable(listData);
            Dictionary<string, string> lsReplace = new Dictionary<string, string>();
            Dictionary<string, string> format = new Dictionary<string, string>();
            format.Add("RegisterDate", "{0:dd/MM/yyyy HH:mm}");
            Dictionary<string, string> lsTitile = new Dictionary<string, string>();
            List<string> lsKeyString = new List<string>();
            lsKeyString.Add("BillCode");
            lsKeyString.Add("RegisterDate");
            lsKeyString.Add("AcceptManPhone");
            byte[] fileArray = Export("MAU_XUAT_DON_PROBLEM.xlsx", 1, dtable, lsTitile, lsReplace, format, true, lsKeyString);
            var bytesdata = File(fileArray, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
            return Json(Convert.ToBase64String(fileArray, 0, fileArray.Length));
        }
        public async Task<IActionResult> Editor()
        {
            return View();
        }

    }
}
