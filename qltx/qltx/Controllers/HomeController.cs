using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using qltx.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace qltx.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Dangdethuexe()
        {
            return View();
        }
        public IActionResult quanlythanhvien()
        {
            return View();
        }
        public IActionResult quanlyxe()
        {
            return View();
        }
        public IActionResult quanlyhangxe()
        {
            return View();
        }
        public IActionResult quanlythuexe()
        {
            return View();
        }
        public IActionResult DangKy()
        {
            return View();
        }
        public IActionResult DangNhap()
        {
            return View();
        }
        public IActionResult Profile()
        {
            return View();
        }
        public IActionResult HopDong()
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
