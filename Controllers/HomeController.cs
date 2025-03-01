using GameStorm.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GameStorm.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult index()
        {
            return View();
        }

        public IActionResult Tienda()
        {
            return View();
        }
        public IActionResult soporte()
        {
            return View();
        }

        public IActionResult Biblioteca()
        {
            return View();
        }

        public IActionResult Login() 
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
