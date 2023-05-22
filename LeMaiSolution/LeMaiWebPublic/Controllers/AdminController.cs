using LeMaiDomain.Models;
using LeMaiLogic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace LeMaiWebPublic.Controllers
{
    public class AdminController : BaseController
    {
        BaseLogicConnectionData dataConnection = new BaseLogicConnectionData();
        public AdminController(ILogger<AdminController> logger, IConfiguration configuration) : base(logger)
        {
            dataConnection.ConnectionString = configuration.GetConnectionString("DefaultConnection");
            dataConnection.Schema = "dbo";
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Slider()
        {
            var model = new WebSliderModel();
            model.slider = new LeMaiDomain.WebBannerSlider();
            return View(model);
        }
        [HttpPost]
        public IActionResult Slider(WebSliderModel input)
        {
            var model = new WebSliderModel();
            model.slider = new LeMaiDomain.WebBannerSlider();
            return View(model);
        }
        public IActionResult SliderList()
        {
            return View(new WebSliderModel());
        }


    }
}
