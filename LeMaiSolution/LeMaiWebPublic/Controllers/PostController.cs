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

namespace LeMaiWebPublic.Controllers
{
    public class PostController : BaseController
    {
        BaseLogicConnectionData dataConnection = new BaseLogicConnectionData();
        private GExpBillLogic _logicbill;
        private WebsitePostLogic _logic;
        public PostController(ILogger<PostController> logger, IConfiguration configuration) : base(logger)
        {
            dataConnection.ConnectionString = configuration.GetConnectionString("DefaultConnection");
            dataConnection.Schema = "dbo";
            _logicbill = new GExpBillLogic(dataConnection);
            _logic = new WebsitePostLogic(dataConnection);

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
    }
}
