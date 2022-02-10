using Microsoft.AspNetCore.Mvc;
using PassingDataViewToController.Models;
using System.Diagnostics;

namespace PassingDataViewToController.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["Message"] = "Hello ASP Net";
            ViewBag.Msg = "Hello C#";

            dynamic value = 10;
            ViewBag.Data = value;

            value = "Hello .Net Core";
            ViewBag.Data1 = value;
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