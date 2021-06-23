using System;
using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace LocalizationApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStringLocalizer<HomeController> _stringLocalizer;

        public HomeController(IStringLocalizer<HomeController> stringLocalizer)
        {
            _stringLocalizer = stringLocalizer;
        }

        public IActionResult Index()
        {
            ViewData["Header"] = _stringLocalizer["Header"];
            ViewData["Message"] = _stringLocalizer["Message"];

            return View();
        }

        public IActionResult ShowCulture()
        {
            string currentCI = CultureInfo.CurrentCulture.Name;
            string currentUiCI = CultureInfo.CurrentUICulture.Name;

            return Content($"Current culture name: {currentCI}{Environment.NewLine}Current culture UI name: {currentUiCI}");
        }
    }
}
