using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using POE_Project.Models;

namespace POE_Project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Lecturer()
        {
            return View();
        }

        public IActionResult Coordinator()
        {
            return View();
        }

        public IActionResult Manager()
        {
            return View();
        }

        public IActionResult Status()
        {
            return View();
        }
    }
}
