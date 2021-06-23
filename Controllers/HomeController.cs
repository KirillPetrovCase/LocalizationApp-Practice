using System;
using System.Globalization;
using Microsoft.AspNetCore.Mvc;

namespace LocalizationApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult ShowCulture()
        {
            return Content($"Current culture name: {CultureInfo.CurrentCulture.Name} {Environment.NewLine}Current culture UI name: {CultureInfo.CurrentUICulture.Name}");
        }
    }
}
