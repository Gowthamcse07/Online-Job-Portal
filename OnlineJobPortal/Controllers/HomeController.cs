using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OnlineJobPortal.Models;

namespace OnlineJobPortal.Controllers
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
            return View();
        }

        public IActionResult Jobs()
        {
            return View();
        }

        public IActionResult Companies()
        {
            return View();
        }

        public IActionResult SalaryInsights()
        {
            return View();
        }

        public IActionResult CareerAdvice()
        {
            return View();
        }

        public IActionResult JobSearch()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult UpdateProfile()
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
