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

namespace LeMaiWebPublic.Controllers
{
    public class PostController : BaseController
    {
        BaseLogicConnectionData dataConnection = new BaseLogicConnectionData();
        private GExpBillLogic _logicbill;
        private WebsitePostLogic _logic;
        private UserManagerLogic _logicUser;
        public PostController(ILogger<PostController> logger, IConfiguration configuration) : base(logger)
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
#if DEBUG
                return RedirectToAction("CreateOrder", "Post");
#else
    return RedirectToAction("CreateOrder", "Post");
#endif
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
            return RedirectToAction("CreateOrder", "Post");
#else
    return RedirectToAction("Index", "Post");
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
                return RedirectToAction("DangNhap", "Post");
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
            item.AcceptProvince = input.AcceptProvinceSelected;
            item.AcceptDistrict = input.AcceptDistrictSelected;
            item.AcceptWard = input.AcceptWardSelected;
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
            if(input.SaveAndSend)
            {
                // Gửi đơn qua bên đơn vị thứ 3
            }    
            result.ResultString = insert.BillCode;

            return Json(result);
        }
    }
}
