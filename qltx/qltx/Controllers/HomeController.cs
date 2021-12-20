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

        public IActionResult Index1()
        {
            ViewBag.i = 1;
            return View("Index");
        }
        public IActionResult Index2()
        {
            ViewBag.i = 2;
            return View("Index");
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Dangdethuexe()
        {
            return View();
        }
        public IActionResult thongtinxe()
        {
            return View();
        }
        public IActionResult thuexe()
        {
            return View();
        }
        public IActionResult quanlythanhvien()
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(qltx.Models.StoreContext)) as StoreContext;
            List<nguoidung> kh = context.Getthanhvien();
            ViewData.Model = kh;
            //StoreContext context = new StoreContext("server=127.0.0.1;user id=root;password=;port=3307;database=quanlythuexe;");
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
            TempData["AlertMessage"] = null;
            return View();
        }
        public IActionResult DK()
        {
            TempData["AlertMessage"] = "Đăng ký thành công";
            TempData["AlertType"] = "alert-success";
            return View("DangKy");
        }
        public IActionResult DangNhap()
        {

            return View();
        }
        public IActionResult DN1()
        {

            return View();
        }
        public IActionResult DN2()
        {

            return View();
        }
        public IActionResult Profile()
        {
            return View();
        }
        public IActionResult HopDong1()
        {
            ViewBag.i = 1;
            return View("HopDong");
        }
        public IActionResult HopDong2()
        {
            ViewBag.i = 2;
            return View("HopDong");
        }
        public IActionResult DN(string email, string password)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(qltx.Models.StoreContext)) as StoreContext;
            int id = context.Timthanhvien(email, password);
            var li = new List<string>()
                    {
                        "1",
                        "2",
                        "3",
                        "4"
                    };
            ViewBag.Productname_List = li;
            ViewBag.MobileCount_List = li;
            if (id == 1) return View("DN1");
            if (id == 2) return View("DN2");
            TempData["AlertMessage"] = "Tài khoản hoặc mật khẩu không đúng!";
            TempData["AlertType"] = "alert-warning";

            return View("DangNhap");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
