
using qltx.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace qltx.Controllers
{
    public class HomeController : Controller
    {

        string SessionName = "_Name";
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
            StoreContext context = HttpContext.RequestServices.GetService(typeof(qltx.Models.StoreContext)) as StoreContext;
            string i = HttpContext.Session.GetString(SessionName);
            TempData["Usid"] = i;
            List<thuonghieu> th = context.Gethangxe();
            List<xe> kh = context.GetxeCuaNguoiDung(i);
            ViewBag.thuonghieuchodangky = th;
            ViewData.Model = kh;
            ViewBag.Name = HttpContext.Session.GetString(SessionName);
            return View();

        }
        public IActionResult Pagethongtinxe(int Page)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(qltx.Models.StoreContext)) as StoreContext;
            List<xe> kh = context.Getxe();
            ViewData.Model = kh;
            TempData["Page"] = Page;
            //StoreContext context = new StoreContext("server=127.0.0.1;user id=root;password=;port=3307;database=quanlythuexe;");
            return View("thongtinxe");
        }
        public IActionResult thongtinxe()
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(qltx.Models.StoreContext)) as StoreContext;
            List<xe> kh = context.Getxe();
            ViewData.Model = kh;
            TempData["Page"] = 6;
            //StoreContext context = new StoreContext("server=127.0.0.1;user id=root;password=;port=3307;database=quanlythuexe;");
            return View("thongtinxe");
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
            return View();

        }
        public IActionResult Timthanhvien(string id_tim)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(qltx.Models.StoreContext)) as StoreContext;
            List<nguoidung> kh = context.Timthanhvien(id_tim);
            
            if (kh.Any())
            {
                ViewData.Model = kh;
                return View("quanlythanhvien");
            }
            TempData["AlertMessage"] = "Không tìm thấy";
            TempData["AlertType"] = "alert-warning";
            context = HttpContext.RequestServices.GetService(typeof(qltx.Models.StoreContext)) as StoreContext;
             kh = context.Getthanhvien();
            ViewData.Model = kh;
            return View("quanlythanhvien");
        }
        public IActionResult Timhangxe(string id_tim)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(qltx.Models.StoreContext)) as StoreContext;
            List<thuonghieu> kh = context.Timhangxe(id_tim);           
            if (kh.Any())
            {
                ViewData.Model = kh;
                return View("quanlyhangxe");
            }
            TempData["AlertMessage"] = "Không tìm thấy";
            TempData["AlertType"] = "alert-warning";
            context = HttpContext.RequestServices.GetService(typeof(qltx.Models.StoreContext)) as StoreContext;
            kh = context.Gethangxe();
            ViewData.Model = kh;
            return View("quanlyhangxe");
        }
        public IActionResult Timxe(string id_tim)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(qltx.Models.StoreContext)) as StoreContext;
            List<xe> kh = context.Timxe(id_tim);
            if (kh.Any())
            {
                ViewData.Model = kh;
                return View("quanlyxe");
            }
            TempData["AlertMessage"] = "Không tìm thấy";
            TempData["AlertType"] = "alert-warning";
            context = HttpContext.RequestServices.GetService(typeof(qltx.Models.StoreContext)) as StoreContext;
            kh = context.Getxe();
            ViewData.Model = kh;
            return View("quanlyxe");
        }
        public IActionResult Timthuexe(string id_tim)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(qltx.Models.StoreContext)) as StoreContext;
            List<thuexe> kh = context.Timthuexe(id_tim);
            if (kh.Any())
            {
                ViewData.Model = kh;
                return View("quanlythuexe");
            }
            TempData["AlertMessage"] = "Không tìm thấy";
            TempData["AlertType"] = "alert-warning";
            context = HttpContext.RequestServices.GetService(typeof(qltx.Models.StoreContext)) as StoreContext;
            kh = context.Getthuexe();
            ViewData.Model = kh;
            return View("quanlythuexe");
        }
        public IActionResult Xoanguoidung(string id)
        {

            StoreContext context = HttpContext.RequestServices.GetService(typeof(qltx.Models.StoreContext)) as StoreContext;
            int[] count = context.Xoanguoidung(id);
            if (count.Length != 0)
            {
                TempData["AlertMessage"] = "Xóa thành công";
                TempData["AlertType"] = "alert-success";
            }
            context = HttpContext.RequestServices.GetService(typeof(qltx.Models.StoreContext)) as StoreContext;
            List<nguoidung> kh = context.Getthanhvien();
            ViewData.Model = kh;
            //StoreContext context = new StoreContext("server=127.0.0.1;user id=root;password=;port=3307;database=quanlythuexe;");
            return View("quanlythanhvien");

        }
        public IActionResult Xoahangxe(string id)
        {

            StoreContext context = HttpContext.RequestServices.GetService(typeof(qltx.Models.StoreContext)) as StoreContext;
            int[] count = context.Xoahangxe(id);
            if (count.Length != 0)
            {
                TempData["AlertMessage"] = "Xóa thành công";
                TempData["AlertType"] = "alert-success";
            }
            context = HttpContext.RequestServices.GetService(typeof(qltx.Models.StoreContext)) as StoreContext;
            List<thuonghieu> kh = context.Gethangxe();
            ViewData.Model = kh;
            return View("quanlyhangxe");

        }
        public IActionResult Xoaxe(string id)
        {

            StoreContext context = HttpContext.RequestServices.GetService(typeof(qltx.Models.StoreContext)) as StoreContext;
            int[] count = context.Xoaxe(id);
            if (count.Length != 0)
            {
                TempData["AlertMessage"] = "Xóa thành công";
                TempData["AlertType"] = "alert-success";
            }
            context = HttpContext.RequestServices.GetService(typeof(qltx.Models.StoreContext)) as StoreContext;
            List<xe> kh = context.Getxe();
            ViewData.Model = kh;
            return View("quanlyxe");

        }
        public IActionResult XoaxeCuaNguoiDung(string id)
        {

            StoreContext context = HttpContext.RequestServices.GetService(typeof(qltx.Models.StoreContext)) as StoreContext;
            int[] count = context.Xoaxe(id);
            if (count.Length != 0)
            {
                TempData["AlertMessage"] = "Xóa thành công";
                TempData["AlertType"] = "alert-success";
            }
            context = HttpContext.RequestServices.GetService(typeof(qltx.Models.StoreContext)) as StoreContext;
            string i = HttpContext.Session.GetString(SessionName);
            TempData["Usid"] = i;
            List<thuonghieu> th = context.Gethangxe();
            List<xe> kh = context.GetxeCuaNguoiDung(i);
            ViewBag.thuonghieuchodangky = th;
            ViewData.Model = kh;
            ViewBag.Name = HttpContext.Session.GetString(SessionName);
            return View("Dangdethuexe");

        }
        public IActionResult quanlyxe()
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(qltx.Models.StoreContext)) as StoreContext;
            List<xe> kh = context.Getxe();
            ViewData.Model = kh;
            //StoreContext context = new StoreContext("server=127.0.0.1;user id=root;password=;port=3307;database=quanlythuexe;");
            return View();
        }
        public IActionResult quanlyhangxe()
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(qltx.Models.StoreContext)) as StoreContext;
            List<thuonghieu> kh = context.Gethangxe();
            ViewData.Model = kh;
            TempData["tongxe"] = 5;
            //StoreContext context = new StoreContext("server=127.0.0.1;user id=root;password=;port=3307;database=quanlythuexe;");
            return View();
            
        }
        public IActionResult quanlythuexe()
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(qltx.Models.StoreContext)) as StoreContext;
            List<thuexe> kh = context.Getthuexe();
            ViewData.Model = kh;
            return View();

           
        }
        public IActionResult DangKy()
        {
            TempData["AlertMessage"] = null;
            return View();
        }
        public IActionResult DK(nguoidung nd)
        {
            int count;
            StoreContext context = HttpContext.RequestServices.GetService(typeof(qltx.Models.StoreContext)) as StoreContext;
            count = context.ThemUser(nd);

            if (count > 0)
            {
                TempData["AlertMessage"] = "Đăng ký thành công";
                TempData["AlertType"] = "alert-success";
            }
            else
            {
                TempData["AlertMessage"] = "Đăng ký không thành công";
                TempData["AlertType"] = "alert-danger";
            }
            return View("DangKy");
        }
        public IActionResult ThemXe(xe xcnd)
        {
            int count;
            StoreContext context = HttpContext.RequestServices.GetService(typeof(qltx.Models.StoreContext)) as StoreContext;
            count = context.InsertXe(xcnd);

            if (count > 0)
            {
                TempData["AlertMessage"] = "đăng ký thành công";
                TempData["AlertType"] = "alert-success";
            }
            else
            {
                TempData["AlertMessage"] = "đăng ký không thành công";
                TempData["AlertType"] = "alert-danger";
            }
            string i = HttpContext.Session.GetString(SessionName);
            TempData["Usid"] = i;
            List<thuonghieu> th = context.Gethangxe();
            List<xe> kh = context.GetxeCuaNguoiDung(i);
            ViewBag.thuonghieuchodangky = th;
            ViewData.Model = kh;
            ViewBag.Name = HttpContext.Session.GetString(SessionName);
            return View("Dangdethuexe");
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
            StoreContext context = HttpContext.RequestServices.GetService(typeof(qltx.Models.StoreContext)) as StoreContext;
            List<chart> list = context.Getsoluongxe();
            List<nguoidung> nd = context.thuenhieunhat();
            int tongxe = context.tongxe();
            ViewData["tongxe"] = tongxe;
            int tongnd = context.tongnd();
            ViewData["tongnd"] = tongnd;
            int tongxedt = context.tongxedt();
            ViewData["tongxedt"] = tongxedt;
            ViewData["xe"] = list;
            list = context.Getdoanhso();
            ViewData["xe1"] = list;
            ViewData["nd"] = nd;
            return View();
        
        }
        public IActionResult HopDong()
        {
            ViewBag.i = 1;
            StoreContext context = HttpContext.RequestServices.GetService(typeof(qltx.Models.StoreContext)) as StoreContext;
            string i = HttpContext.Session.GetString(SessionName);
            ViewBag.Name = HttpContext.Session.GetString(SessionName);
            return View(context.ViewHopDong(i));
        }
        public IActionResult HopDong2()
        {
            ViewBag.i = 2;
            return View("HopDong");
        }
        public IActionResult DN(string email, string password)
        {

            StoreContext context = HttpContext.RequestServices.GetService(typeof(qltx.Models.StoreContext)) as StoreContext;
            nguoidung nd = context.Timthanhvien(email, password);
            if (nd.quyen == 1)
            {
                HttpContext.Session.SetString(SessionName, nd.id);
                return View("DN1");
            }
            if (nd.quyen == 2)
            {
                HttpContext.Session.SetString(SessionName, nd.id);
                context = HttpContext.RequestServices.GetService(typeof(qltx.Models.StoreContext)) as StoreContext;
                List<chart> list = context.Getsoluongxe();
                List<nguoidung> nd1 = context.thuenhieunhat();
                int tongxe = context.tongxe();
                ViewData["tongxe"] = tongxe;
                int tongxedt = context.tongxedt();
                ViewData["tongxedt"] = tongxedt;
                int tongnd = context.tongnd();
                ViewData["tongnd"] = tongnd;
                ViewData["xe"] = list;
                list = context.Getdoanhso();
                ViewData["xe1"] = list;
                ViewData["nd"] = nd1;
                return View("DN2");
            }
            TempData["AlertMessage"] = "Tài khoản hoặc mật khẩu không đúng!";
            TempData["AlertType"] = "alert-warning";

            return View("DangNhap");
        }
    

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Profile(string Id)
        {

            StoreContext context = HttpContext.RequestServices.GetService(typeof(qltx.Models.StoreContext)) as StoreContext;
            string i = HttpContext.Session.GetString(SessionName);
            nguoidung nd = context.ViewUser(i);
            ViewData.Model = nd;
            ViewBag.Name = HttpContext.Session.GetString(SessionName);
            return View();
        }

        public IActionResult CapNhatUser(nguoidung nd)
        {
            ViewData.Model = nd;
            int count;
            StoreContext context = HttpContext.RequestServices.GetService(typeof(qltx.Models.StoreContext)) as StoreContext;
            count = context.UpdateUser(nd);

            if (count > 0)
            {
                TempData["AlertMessage"] = "Cập nhật thành công";
                TempData["AlertType"] = "alert-success";
            }
            else
            {
                TempData["AlertMessage"] = "Cập nhật không thành công";
                TempData["AlertType"] = "alert-danger";
            }
            return View("Profile");
        }
        public IActionResult CapNhatXe(xe xcnd)
        {
            int count;
            StoreContext context = HttpContext.RequestServices.GetService(typeof(qltx.Models.StoreContext)) as StoreContext;
            count = context.UpdateXe(xcnd);

            if (count > 0)
            {
                TempData["AlertMessage"] = "Cập nhật thành công";
                TempData["AlertType"] = "alert-success";
            }
            else
            {
                TempData["AlertMessage"] = "Cập nhật không thành công";
                TempData["AlertType"] = "alert-danger";
            }
            string i = HttpContext.Session.GetString(SessionName);
            TempData["Usid"] = i;
            List<thuonghieu> th = context.Gethangxe();
            List<xe> kh = context.GetxeCuaNguoiDung(i);
            ViewBag.thuonghieuchodangky = th;
            ViewData.Model = kh;
            ViewBag.Name = HttpContext.Session.GetString(SessionName);
            return View("Dangdethuexe");
        }


    }
    


}