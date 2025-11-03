using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTWeb11_Bai01.Controllers
{
    public class KhachHangController : Controller
    {
        // GET: KhachHang
        [HttpGet]
        public ActionResult Index()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string username, string password)
        {
            if (IsValidUser(username, password))
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không đúng.");
                return View();
            }
        }
        private bool IsValidUser(string username, string password)
        {
            return (username == "admin" && password == "123");
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(string username, string email, string password, string confirmPassword)
        {
            if (password != confirmPassword)
            {
                ModelState.AddModelError("", "Mật khẩu xác nhận không khớp.");
                return View(); 
            }
            bool isCreatedSuccessfully = CreateUser(username, email, password);

            if (isCreatedSuccessfully)
            {
                return RedirectToAction("Login", "Account");
            }
            else
            {
                ModelState.AddModelError("", "Tên đăng nhập hoặc email đã tồn tại.");
                return View();
            }
        }
        
        private bool CreateUser(string username, string email, string password)
        {
            return true; 
        }
    }

}
