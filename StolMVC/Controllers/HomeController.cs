using Microsoft.AspNetCore.Mvc;
using StolMVC.Models;
using System.Diagnostics;

namespace StolMVC.Controllers
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

        [HttpPost]
        public ActionResult Submit(UserModel user)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", user);
            }

            return View("Submit", user); // Заменили "Privacy" на "Submit"
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}