using LeMaiDomain.Models;
using LeMaiLogic;
using LeMaiModelWebApi.Order;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using LeMaiDomain;
using LeMaiLogic.Logic;
using System;
using System.Linq;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.VariantTypes;
using System.IO;
using System.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using GenCode128;
using QRCoder;
using System.Data;

namespace LeMaiWebPublic.Controllers
{
    public class POrderController : BaseController
    {
        BaseLogicConnectionData dataConnection = new BaseLogicConnectionData();
        private GExpBillLogic _logicbill;
        private WebsitePostLogic _logic;
        private UserManagerLogic _logicUser;
        public POrderController(ILogger<POrderController> logger, IConfiguration configuration) : base(logger)
        {
            dataConnection.ConnectionString = configuration.GetConnectionString("DefaultConnection");
            dataConnection.Schema = "dbo";
            _logicbill = new GExpBillLogic(dataConnection);
            _logic = new WebsitePostLogic(dataConnection);
            _logicUser = new UserManagerLogic(dataConnection);

        }
        public IActionResult DangNhap()
        {
            string userId = GetUserId();
            if (!string.IsNullOrEmpty(userId))
            {
                return RedirectToAction("CreateOrder", "POrder");
            }
            return View();
        }
        [HttpPost]
        //[Route("khach-hang")]
        public async Task<IActionResult> DangNhap(string customerCode, string customerPass)
        {
            var profileAccount = await _logic.LoginCustomer(customerCode, customerPass);
            if (profileAccount == null)
            {
                ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không đúng !");
                ViewBag.ShowErros = "Tên đăng nhập hoặc mật khẩu không đúng !";
                return View("DangNhap");
            }
            var claims = new List<Claim>
                            {
                            new Claim(ClaimTypes.Name, profileAccount.FullName),
                            new Claim("userId", profileAccount.Id),
                            new Claim("post", profileAccount.CardId),
                            new Claim("FeeId", profileAccount.IdAccountIntro)
                            };
            var claimsIdentity = new ClaimsIdentity(
                claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties
            {
            };
            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
            new ClaimsPrincipal(claimsIdentity), authProperties);
#if DEBUG
            return RedirectToAction("CreateOrder", "POrder");
#else
    return RedirectToAction("Index", "POrder");
#endif
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> CreateOrder()
        {
            string userId = GetUserId();
            if (string.IsNullOrEmpty(userId))
            {
                return RedirectToAction("DangNhap", "POrder");
            }
            string postId = GetPost();
            CreateOrderModel model = new CreateOrderModel();
            model.UserId = userId;
            model.PostId = postId;

            var user = await _logicUser.GetAccountObject(userId);
            model.SiteCode = user.IdAccountIntro;
            model.Freight = 25000;
            model.PayTypeList = await _logicbill.GetDanhSachThanhToan();
            model.PayTypeSelected = model.PayTypeList.FirstOrDefault().Id;

            model.ProviderList = await _logicbill.GetDanhSachProvider(postId);
            model.ProviderSelected = model.ProviderList.FirstOrDefault().Id;

            model.ShipTypeList = await _logicbill.GetDanhSachGiaoHang();
            model.ShipTypeSelected = model.ShipTypeList.FirstOrDefault().Id;

            model.AcceptProvinceList = await _logicbill.GetDanhSachTinh();
            model.AcceptProvinceSelected = model.AcceptProvinceList.FirstOrDefault().ProvinceID.ToString();

            model.PickupProvinceList = await _logicbill.GetDanhSachTinh();
            model.PickupProvinceSelected = model.PickupProvinceList.FirstOrDefault().ProvinceID.ToString();

            model.AcceptDistrictList = await _logicbill.GetDanhSachHuyen(model.AcceptProvinceSelected);
            model.AcceptDistrictSelected = model.AcceptDistrictList.FirstOrDefault().DistrictID.ToString();

            model.PickupDistrictList = await _logicbill.GetDanhSachHuyen(model.PickupProvinceSelected);
            model.PickupDistrictSelected = model.PickupDistrictList.FirstOrDefault().DistrictID.ToString();

            model.AcceptWardList = await _logicbill.GetDanhSachXa(model.AcceptDistrictSelected);
            model.AcceptWardSelected = model.AcceptWardList.FirstOrDefault().WardId;

            model.PickupWardList = await _logicbill.GetDanhSachXa(model.PickupDistrictSelected);
            model.PickupWardSelected = model.PickupWardList.FirstOrDefault().WardId;

            model.IsPickup = false;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> GetCalculator(string IdTinh, string IdHuyen, string? Weight, string Post, string CustomerId)
        {
            string w = Weight == null ? "0" : Weight.ToString();
            var customer = _logic.GetCustomerDetail(CustomerId);
            string FeeId = string.Empty;
            if (customer != null)
            {
                FeeId = customer.FK_GiaCuoc;
            }
            string result = await _logicbill.GetCalculatorFee(w, FeeId, IdTinh, Post, IdHuyen);
            return Json(result);
        }
        [HttpPost]
        public async Task<IActionResult> GetSuggestProvider(string IdTinh, string IdHuyen, string? Weight, string Post)
        {
            string w = Weight == null ? "0" : Weight.ToString();
            var providers = await _logicbill.GetDanhSachProvider(Post);
            GExpProvider pro = providers.Where(u => string.IsNullOrEmpty(u.WhiteListProvince) == false && u.WhiteListProvince.Contains(IdTinh)).FirstOrDefault();
            if (pro == null)
            {
                int weight = 0;
                if (Int32.TryParse(w, NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out weight))
                {
                    // Select Provider
                    foreach (var item in providers)
                    {
                        if (weight > item.InitWeightSelect && weight <= item.InitWeightSelectMax)
                        {
                            pro = item;
                            break;
                        }
                    }
                }
            }

            // Check cuối cùng
            if (pro == null)
            {
                pro = providers.FirstOrDefault();
            }
            return Json(pro.Id);
        }
        [HttpPost]
        public async Task<IActionResult> GetSender(string Phone, string Post)
        {
            ObjectMan result = new ObjectMan();
            var customer = _logicbill.GetThongTinKhachHang(Phone, Post);
            if (customer != null)
            {
                result.Found = true;
                result.CustomerId = customer.Id;
                result.Phone = customer.CustomerPhone;
                result.Name = customer.CustomerName;
                result.Address = customer.DiaChi;
                var provinces = await _logicbill.GetDanhSachTinh();
                result.ProvinceList = provinces.Select(h => new DictionInt { Key = h.ProvinceID, Name = h.ProvinceName }).ToList();

                result.SelectProvince = customer.ProvinceId.GetValueOrDefault(0);

                var districts = await _logicbill.GetDanhSachHuyen(result.SelectProvince.ToString());
                result.DistrictList = districts.Select(h => new DictionInt { Key = h.DistrictID, Name = h.DistrictName }).ToList();
                result.SelectDistrict = customer.DistrictId.GetValueOrDefault(0);

                var wards = await _logicbill.GetDanhSachXa(result.SelectDistrict.ToString());
                result.WardList = wards.Select(h => new DictionString { Key = h.WardId, Name = h.WardName }).ToList();
                result.SelectWard = customer.WardId;
            }
            else
            {
                result.Found = false;
            }
            return Json(result);
        }
        [HttpPost]
        public async Task<IActionResult> GetAccept(string Phone)
        {
            ObjectMan result = new ObjectMan();
            var accept = _logicbill.GetThongTinNguoiNhan(Phone);
            if (accept != null)
            {
                result.Found = true;
                result.CustomerId = accept.Id;
                result.Phone = accept.AcceptPhone;
                result.Name = accept.AcceptMan;
                result.Address = accept.AcceptAddress;
                var provinces = await _logicbill.GetDanhSachTinh();
                result.ProvinceList = provinces.Select(h => new DictionInt { Key = h.ProvinceID, Name = h.ProvinceName }).ToList();
                result.SelectProvince = accept.AcceptProvince;

                var districts = await _logicbill.GetDanhSachHuyen(result.SelectProvince.ToString());
                result.DistrictList = districts.Select(h => new DictionInt { Key = h.DistrictID, Name = h.DistrictName }).ToList();
                result.SelectDistrict = accept.AcceptDistrict;

                var wards = await _logicbill.GetDanhSachXa(result.SelectDistrict.ToString());
                result.WardList = wards.Select(h => new DictionString { Key = h.WardId, Name = h.WardName }).ToList();
                result.SelectWard = accept.AcceptWard;
            }
            else
            {
                result.Found = false;
            }
            return Json(result);
        }
        [HttpPost]
        public async Task<IActionResult> TaoDonHang([FromBody] CreateOrderModelInput input)
        {
            if (input == null)
            {
                return BadRequest();
            }
            BaseOutput result = new BaseOutput();
            try
            {
                GExpBillLogicInputDto item = new GExpBillLogicInputDto();
                item.BillWeight = input.BillWeigt;
                item.FeeWeight = input.FeeWeight;
                item.RegisterUser = input.UserId;

                item.RegisterSiteCode = input.PostId;
                item.Freight = input.Freight;
                item.PayType = input.PayTypeSelected;
                item.COD = input.COD;
                item.SendMan = input.SendMan;
                item.SendManPhone = input.SendManPhone;
                item.SendManAddress = input.SendAddress;

                item.AcceptProvinceCode = Int32.Parse(input.AcceptProvinceSelected);
                item.AcceptDistrictCode = Int32.Parse(input.AcceptDistrictSelected);
                item.AcceptWardCode = input.AcceptWardSelected;

                item.AcceptMan = input.AcceptMan;
                item.AcceptManPhone = input.AcceptManPhone;
                item.AcceptManAddress = input.AcceptAddress;

                item.AcceptProvince = input.AcceptProvinceName;
                item.AcceptDistrict = input.AcceptDistrictName;
                item.AcceptWard = input.AcceptWardName;

                item.LastUpdateUser = input.UserId;
                item.Note = input.Note;
                item.BT3Type = input.ProviderSelected;
                item.GoodsName = input.GoodName;

                item.IsReceiveBill = false;
                item.GoodsNumber = 1;
                item.GoodsCode = "CODE";

                item.GoodsW = input.DIM_W;
                item.GoodsH = input.DIM_H;
                item.GoodsL = input.DIM_L;
                item.FK_Customer = string.IsNullOrEmpty(input.CustomerId) ? "0000" : input.CustomerId;

                item.FK_ProviderAccount = input.ProviderSelected;
                item.FK_PaymentType = input.PayTypeSelected;
                item.FK_ShipType = input.ShipTypeSelected;
                var user = await _logicUser.GetAccountObject(input.UserId);
                item.FullName = user.FullName;
                item.SiteCode = user.IdAccountIntro;
                // Get pickupAddress
                item.Pickup = input.IsPickup;
                item.AddressPickup = input.PickupAddress;
                item.ProvincePickup = input.PickupProvinceSelected;
                item.DistricPickup = input.PickupDistrictSelected;
                item.WardPickup = input.PickupWardSelected;
                item.NamePickup = input.PickupMan;
                item.PhonePickup = input.PickupManPhone;


                GExpBill insert = await _logicbill.Create(item);
                if (input.SaveAndSend)
                {
                    // Gửi đơn qua bên đơn vị thứ 3
                }
                result.ResultString = insert.BillCode;
                result.Code = 200;
            }
            catch (Exception ex)
            {
                result.Code = 0;
                result.Error = ex.Message;
            }
            return Json(result);
        }

        public IActionResult PrintBill(string billCode)
        {
            try
            {


                if (!string.IsNullOrEmpty(billCode))
                {
                    billCode = billCode.Replace(",", "','");
                    billCode = "'" + billCode + "'";
                }
                else
                {
                    billCode = "''";
                }
                var bills = _logicbill.GetBills(billCode);

                var document = new PdfDocument();
                document.Info.Title = "Bill 76x130";
                var drawFormatCenter = XStringFormats.Center;
                var drawFormatLeft = XStringFormats.CenterLeft;
                var drawFormatRight = XStringFormats.CenterRight;

                var drawBrush = XBrushes.Black;

                XFont fontTimeNewRoman12Bold = new XFont("Arial", 12, XFontStyle.Bold);
                XFont fontTimeNewRoman10Bold = new XFont("Time New Roman", 10, XFontStyle.Bold);
                XFont fontTimeNewRoman8Bold = new XFont("Time New Roman", 8, XFontStyle.Bold);
                XFont fontTimeNewRoman7 = new XFont("Time New Roman", 7);
                XFont fontTimeNewRoman8 = new XFont("Time New Roman", 8);
                XFont fontTimeNewRoman30Bold = new XFont("Time New Roman", 30, XFontStyle.Bold);
                XFont fontTimeNewRoman20Bold = new XFont("Time New Roman", 20, XFontStyle.Bold);
                var drawRect = new XRect();
                int trucdung = 0;
                int trucngang = 0;
                foreach (var expCon in bills)
                {
                    trucdung = 0;
                    trucngang = 0;
                    var page = document.AddPage();
                    page.Width = 299;
                    page.Height = 511;
                    XGraphics e = XGraphics.FromPdfPage(page);
                    var tf = new XTextFormatter(e);
                    // Line Đứng 1
                    e.DrawLine(XPens.Black, trucdung, 5, trucdung, 505);
                    // Line Đứng 2
                    trucdung = 143;
                    e.DrawLine(XPens.Black, trucdung, 164, trucdung, 340);
                    // Line Đứng 3
                    trucdung = 295;
                    e.DrawLine(XPens.Black, trucdung, 5, trucdung, 505);
                    // Line Ngang 1
                    trucngang = 62;
                    e.DrawLine(XPens.Black, 0, trucngang, 295, trucngang);
                    // Line Ngang 2
                    trucngang = 124;
                    e.DrawLine(XPens.Black, 0, trucngang, 295, trucngang);
                    // Line Ngang 3
                    trucngang = 164;
                    e.DrawLine(XPens.Black, 0, trucngang, 295, trucngang);
                    // Line Ngang 4
                    trucngang = 226;
                    e.DrawLine(XPens.Black, 0, trucngang, 295, trucngang);
                    // Line Ngang 5
                    trucngang = 340;
                    e.DrawLine(XPens.Black, 0, trucngang, 295, trucngang);

                    drawRect = new XRect(143, 15, 140, fontTimeNewRoman8.Height);
                    e.DrawString("Tổng tiền thu", fontTimeNewRoman8, drawBrush, drawRect, drawFormatRight);
                    // In Số tiền phải thu
                    drawRect = new XRect(143, 35, 143, 20);
                    if (expCon.FK_PaymentType == "GTT")
                    {
                        e.DrawString(expCon.COD.ToString("N0") + " đ", fontTimeNewRoman12Bold, drawBrush, drawRect, drawFormatRight);
                    }
                    else
                    {
                        e.DrawString((expCon.COD + expCon.Freight).ToString("N0") + " đ", fontTimeNewRoman12Bold, drawBrush, drawRect, drawFormatRight);
                    }
                    // In logo

                    drawRect = new XRect(5, 50, 140, fontTimeNewRoman7.Height);
                    e.DrawString(string.Format("{0:HH:mm dd/MM/yyyy}", expCon.RegisterDate) + " " + (expCon.FeeWeight - 2000), fontTimeNewRoman7, drawBrush, drawRect, drawFormatLeft);

                    if (!string.IsNullOrEmpty(expCon.BT3Code))
                    {
                        // Barcode mã vận đơn 
                        drawRect = new XRect(0, 62, 287, 40);
                        var myImage = Code128Rendering.MakeBarcodeImage(expCon.BillCode, 2, true);
                        MemoryStream ms128s = new MemoryStream();
                        myImage.Save(ms128s, System.Drawing.Imaging.ImageFormat.Png);

                        XImage image128s = XImage.FromStream(ms128s);
                        e.DrawImage(image128s, 70, 70, 150, 30);

                        // In dòng mã vận đơn bên dưới
                        drawRect = new XRect(0, 105, 287, fontTimeNewRoman10Bold.Height);
                        e.DrawString(expCon.BillCode, fontTimeNewRoman10Bold, drawBrush, drawRect, drawFormatCenter);
                    }
                    else if (expCon.RunMode == 0)
                    {
                        // Barcode mã vận đơn 
                        var myImage = Code128Rendering.MakeBarcodeImage(expCon.BillCode, 2, true);
                        MemoryStream ms128s = new MemoryStream();
                        myImage.Save(ms128s, System.Drawing.Imaging.ImageFormat.Png);

                        XImage image128s = XImage.FromStream(ms128s);
                        e.DrawImage(image128s, 70, 70, 150, 30);

                        // In dòng mã vận đơn bên dưới
                        drawRect = new XRect(0, 105, 287, fontTimeNewRoman10Bold.Height);
                        e.DrawString(expCon.BillCode, fontTimeNewRoman10Bold, drawBrush, drawRect, drawFormatCenter);
                    }
                    if (string.IsNullOrEmpty(expCon.PrintData))
                    {
                        // In dòng tên nhà cung cấp DV BT3
                        drawRect = new XRect(0, 135, 287, fontTimeNewRoman12Bold.Height);
                        e.DrawString(expCon.PrintLable, fontTimeNewRoman12Bold, drawBrush, drawRect, drawFormatCenter);
                    }
                    else
                    {
                        // Line Đứng X2
                        trucdung = 90;
                        e.DrawLine(XPens.Black, trucdung, 124, trucdung, 164);
                        // Line Đứng X3
                        trucdung = 220;
                        e.DrawLine(XPens.Black, trucdung, 124, trucdung, 164);
                        string[] split = expCon.PrintData.Split(';');
                        if (split.Length >= 3)
                        {
                            // Tên dịch vụ print data
                            drawRect = new XRect(0, 125, 90, fontTimeNewRoman20Bold.Height);
                            e.DrawString(split[0], fontTimeNewRoman20Bold, drawBrush, drawRect, drawFormatCenter);
                            drawRect = new XRect(80, 125, 140, fontTimeNewRoman20Bold.Height);
                            e.DrawString(split[1], fontTimeNewRoman20Bold, drawBrush, drawRect, drawFormatCenter);
                            drawRect = new XRect(220, 125, 60, fontTimeNewRoman20Bold.Height);
                            e.DrawString(split[2], fontTimeNewRoman20Bold, drawBrush, drawRect, drawFormatCenter);
                        }
                    }

                    // In dòng vật phẩm
                    drawRect = new XRect(5, 165, 140, fontTimeNewRoman8Bold.Height);
                    tf.DrawString("Tên vật phẩm:", fontTimeNewRoman8Bold, drawBrush, drawRect);
                    // In tên vật phẩm
                    drawRect = new XRect(10, 180, 140, 30);
                    e.DrawString(expCon.GoodsName, fontTimeNewRoman8Bold, drawBrush, drawRect, drawFormatLeft);

                    drawRect = new XRect(10, 200, 140, fontTimeNewRoman8Bold.Height);
                    e.DrawString(expCon.ShipNoteType, fontTimeNewRoman8Bold, drawBrush, drawRect, drawFormatCenter);
                    // In dòng trọng lượng
                    drawRect = new XRect(148, 165, 140, fontTimeNewRoman8Bold.Height);
                    e.DrawString("Trọng lượng: " + expCon.BillWeight.ToString("N0") + " Gr", fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);
                    // In dòng phương thức thanh toán
                    drawRect = new XRect(148, 182, 140, fontTimeNewRoman8Bold.Height);
                    e.DrawString("Phương thức thanh toán", fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);
                    // In nội dung phương thức thanh toán
                    drawRect = new XRect(143, 200, 140, fontTimeNewRoman8Bold.Height + 5);
                    e.DrawString(expCon.PaymentTypeName, fontTimeNewRoman8Bold, drawBrush, drawRect, drawFormatCenter);

                    // In dòng NHẬN
                    int row = 230;
                    drawRect = new XRect(5, row, 140, fontTimeNewRoman8Bold.Height);
                    e.DrawString("NHẬN", fontTimeNewRoman8Bold, drawBrush, drawRect, drawFormatLeft);

                    // IN TÊN NHẬN
                    drawRect = new XRect(0, row + 12, 140, fontTimeNewRoman8Bold.Height);
                    e.DrawString(expCon.AcceptMan.ToUpper(), fontTimeNewRoman8Bold, drawBrush, drawRect, drawFormatRight);

                    // In dòng chữ GỬI
                    drawRect = new XRect(148, row, 140, fontTimeNewRoman8Bold.Height);
                    e.DrawString("GỬI", fontTimeNewRoman8Bold, drawBrush, drawRect, drawFormatLeft);
                    // IN TÊN GỬI
                    drawRect = new XRect(143, row + 12, 140, fontTimeNewRoman8Bold.Height);
                    e.DrawString(expCon.SendMan.ToUpper(), fontTimeNewRoman8Bold, drawBrush, drawRect, drawFormatRight);

                    row = 255;
                    // In Số điện thoại nhận
                    drawRect = new XRect(5, row, 140, fontTimeNewRoman8.Height);
                    e.DrawString(expCon.AcceptManPhone, fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);

                    if (expCon.RunMode == 0)
                    {
                        // In số điện thoại gửi
                        drawRect = new XRect(148, row, 140, fontTimeNewRoman8.Height);
                        e.DrawString(expCon.SendManPhone, fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);
                    }
                    else
                    {
                        // In số điện thoại gửi
                        drawRect = new XRect(148, row, 140, fontTimeNewRoman8.Height);
                        e.DrawString(expCon.SendManPhone.Replace("0", "*").Replace("9", "*").Replace("7", "*"), fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);
                    }

                    row = 275;
                    //In địa chỉ nhận
                    drawRect = new XRect(5, row, 140, 65);
                    tf.DrawString(expCon.FullAddress, fontTimeNewRoman8, drawBrush, drawRect);

                    // In địa chỉ gửi
                    drawRect = new XRect(148, row, 140, 65);
                    tf.DrawString(expCon.SendManAddress, fontTimeNewRoman8, drawBrush, drawRect);
                    // In chữ [GHI CHÚ]

                    row = 342;
                    drawRect = new XRect(5, row, 140, fontTimeNewRoman8.Height);
                    e.DrawString("GHI CHÚ:", fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);


                    // In dòng ghi chú
                    row = 355;
                    drawRect = new XRect(5, row, 287, 50);
                    //e.DrawString(expCon.Note, fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);
                    tf.DrawString(expCon.Note, fontTimeNewRoman8, drawBrush, drawRect);
                    string codePrint = expCon.BT3Code;

                    if (!string.IsNullOrEmpty(expCon.BT3Code))
                    {
                        codePrint = expCon.BT3Code;
                        // IN MÃ VẠCH VẬN ĐƠN BT3
                        Bitmap bimap = RenderQrCode(codePrint);
                        MemoryStream ms = new MemoryStream();
                        bimap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                        XImage image = XImage.FromStream(ms);

                        e.DrawImage(image, 110, 390);

                        // IN MÃ VẬN ĐƠN BT3
                        row = 455;
                        drawRect = new XRect(0, row, 287, fontTimeNewRoman10Bold.Height);
                        e.DrawString(codePrint, fontTimeNewRoman10Bold, drawBrush, drawRect, drawFormatCenter);
                    }
                    else
                    {
                        codePrint = expCon.BillCode;
                        // IN MÃ VẠCH VẬN ĐƠN BT3
                        Bitmap bimap = RenderQrCode(codePrint);
                        MemoryStream ms = new MemoryStream();
                        bimap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                        XImage image = XImage.FromStream(ms);

                        e.DrawImage(image, 110, 390);
                        // IN MÃ VẬN ĐƠN BT3
                        row = 455;
                        drawRect = new XRect(0, row, 287, fontTimeNewRoman10Bold.Height);
                        e.DrawString(codePrint, fontTimeNewRoman10Bold, drawBrush, drawRect, drawFormatCenter);
                    }

                    // IN DÒNG TỈNH NHẬN HÀNG
                    row = 470;
                    drawRect = new XRect(0, row, 287, fontTimeNewRoman12Bold.Height);
                    e.DrawString(expCon.AcceptProvince, fontTimeNewRoman12Bold, drawBrush, drawRect, drawFormatCenter);
                    // In dòng số lượng
                    row = 490;
                    drawRect = new XRect(5, row, 140, fontTimeNewRoman8.Height);
                    e.DrawString("Số lượng: " + expCon.GoodsNumber.ToString(), fontTimeNewRoman8, drawBrush, drawRect, drawFormatLeft);
                    // In dòng kích thước
                    drawRect = new XRect(143, row, 140, fontTimeNewRoman8Bold.Height);
                    e.DrawString("Kích thước: " + expCon.GoodsW.ToString() + " x " + expCon.GoodsH.ToString() + " x " + expCon.GoodsL.ToString(), fontTimeNewRoman8Bold, drawBrush, drawRect, drawFormatRight);

                }

                if (document.PageCount == 0)
                {
                    document.AddPage();
                }
                MemoryStream stream = new MemoryStream();
                document.Save(stream);
                return File(stream, "application/pdf");
            }
            catch (Exception ex)
            {
                _logger.LogError("Loi print bil", ex.ToString());
                throw;
            }
        }
        private Bitmap RenderQrCode(string text)
        {
            QRCodeGenerator.ECCLevel eccLevel = QRCodeGenerator.ECCLevel.L;
            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(text, eccLevel))
            using (QRCode qrCode = new QRCode(qrCodeData))
            {
                return qrCode.GetGraphic(3, System.Drawing.Color.Black, System.Drawing.Color.White, null, 0);
            }
        }

        [HttpGet]
        public async Task<IActionResult> BillManager()
        {
            BaseBillFilter model = new BaseBillFilter();
            var lsStatus = _logicbill.GetGExpBillStatusAndAll();
            model.ListStatus = lsStatus.Select(h => new BaseStatusFilter { Value = h.Id.ToString(), Name = h.StatusName }).ToList();
            model.FromDate = string.Format("{0:yyyy-MM-dd}", DateTime.Now.AddDays(-15));
            model.Status = "-1,";
            model.ToDate = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
            string postId = GetPost();
            model.KeySearch = string.Empty;
            model.ListBill = await _logicbill.GetList(model.KeySearch, postId, "9999", DateTime.Now.AddDays(-15), DateTime.Now, "9999", string.Empty);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> BillManager(BaseFilter filter)
        {
            BaseBillFilter model = new BaseBillFilter();
            var lsStatus = _logicbill.GetGExpBillStatusAndAll();
            model.ListStatus = lsStatus.Select(h => new BaseStatusFilter { Value = h.Id.ToString(), Name = h.StatusName }).ToList();
            model.Status = filter.Status;

            string userId = GetUserId();
            DateTime fromDate = DateTime.Now.AddDays(-15);
            DateTime toDate = DateTime.Now;
            if (!DateTime.TryParseExact(filter.FromDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out fromDate))
            {
                fromDate = DateTime.Now.AddDays(-15);
            }

            model.FromDate = string.Format("{0:yyyy-MM-dd}", fromDate);

            if (!DateTime.TryParseExact(filter.ToDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out toDate))
            {
                toDate = DateTime.Now;
            }
            model.ToDate = string.Format("{0:yyyy-MM-dd}", toDate);
            string postId = GetPost();
            model.KeySearch = filter.KeySearch;
            model.Status = filter.Status;
            if (string.IsNullOrEmpty(model.Status))
            {
                model.Status = string.Empty;
            }
            else
            {
                model.Status = model.Status.TrimEnd(',');
            }
            model.ListBill = await _logicbill.GetList(model.KeySearch, postId, "9999", fromDate, toDate, "9999", model.Status).ConfigureAwait(true);
            return View(model);
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
