using System.Diagnostics;
using JobApplicationGlobal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace JobApplicationGlobal.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStringLocalizer<HomeController> _localizer;

        public HomeController(IStringLocalizer<HomeController> localizer)
        {
            _localizer = localizer;
        }


        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(JobApplication jobApplication)
        {
            if (ModelState.IsValid)
                ViewBag.Message = _localizer["Your application is accepted"];
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}