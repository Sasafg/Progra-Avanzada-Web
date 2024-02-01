using Microsoft.AspNetCore.Mvc;
using ProyectoWebAvanzada.Models;
using System.Diagnostics;

namespace ProyectoWebAvanzada.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Registry()
        {
            return View();
        }

        public IActionResult Index
            ()
        {
            return View();
        }
    }
}
