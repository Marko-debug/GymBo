using System.Diagnostics;
using GymBo.Models;
using Microsoft.AspNetCore.Mvc;

namespace GymBo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public IActionResult Index()
        {
            return View();
        }
    }
}
