using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LTWeb11_Bai01.Models;

namespace LTWeb11_Bai01.Controllers
{
    public class HomeController : Controller
    {
        Model1 data = new Model1();
        public ActionResult Index()
        {
            ViewBag.ShowBanner = true;
            ViewBag.BannerTitle = "Chào mừng đến với BookStore";
            ViewBag.BannerSubtitle = "Khám phá thế giới sách đa dạng";
            ViewBag.BannerImage = "~/Content/images/banner-home.jpg";
            List<Sach> sach = data.Saches.ToList();
            return View(sach);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult DSMenu_ChuDe()
        {
            List<ChuDe> dsCD = data.ChuDes.ToList();
            return PartialView(dsCD);
        }
        public ActionResult DSMenu_NXB()
        {
            List<NhaXuatBan> dsNXB = data.NhaXuatBans.Take(10).ToList();
            return PartialView(dsNXB); 
        }
        public ActionResult Search(string searchString)
        {
            var books = from s in data.Saches select s;
            ViewBag.ShowBanner = false;

            if (!String.IsNullOrEmpty(searchString))
            {
                books = books.Where(s => s.TenSach.Contains(searchString));
            }

            return View("Index", books.ToList());
        }

        public ActionResult SearchWithPrice(string searchString, int? chuDeId, string[] priceRange)
        {

            var books = data.Saches.AsQueryable(); 
            ViewBag.ShowBanner = false;

            if (!String.IsNullOrEmpty(searchString))
            {
                books = books.Where(s => s.TenSach.Contains(searchString));
            }

            if (chuDeId != null && chuDeId > 0)
            {
                books = books.Where(s => s.MaChuDe == chuDeId);
            }

            if (priceRange != null && priceRange.Length > 0)
            {

                IQueryable<Sach> priceFilteredBooks = books.Where(s => false);

                foreach (var range in priceRange)
                {
                    switch (range)
                    {
                        case "0-10000":
                            priceFilteredBooks = priceFilteredBooks.Concat(
                                books.Where(s => s.GiaBan >= 0 && s.GiaBan <= 10000)
                            );
                            break;
                        case "11000-20000":
                            priceFilteredBooks = priceFilteredBooks.Concat(
                                books.Where(s => s.GiaBan >= 11000 && s.GiaBan <= 20000)
                            );
                            break;
                        case "21000-40000":
                            priceFilteredBooks = priceFilteredBooks.Concat(
                                books.Where(s => s.GiaBan >= 21000 && s.GiaBan <= 40000)
                            );
                            break;
                        case "40001":
                            priceFilteredBooks = priceFilteredBooks.Concat(
                                books.Where(s => s.GiaBan > 40000)
                            );
                            break;
                    }
                }
                books = priceFilteredBooks.Distinct();
            }
            return View("Index", books.ToList());
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                data.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Sach sach = data.Saches
                                    .FirstOrDefault(e => e.MaSach == id);
            var maTG = data.ThamGias.Where(t => t.MaSach == id).Select(x => x.MaTacGia).ToList();
            var tenTG = data.TacGias
                    .Where(tg => data.ThamGias.Any(t => t.MaSach == id && t.MaTacGia == tg.MaTacGia))
                    .Select(tg => tg.TenTacGia)
                    .ToList();
            ViewBag.TenTG = string.Join(", ", tenTG);

            if (sach == null)
            {
                return HttpNotFound();
            }

            return View(sach);
        }

        public ActionResult XemTheoChuDe(int id)
        {
            List<Sach> sach= data.Saches.Where(s => s.MaChuDe == id).ToList();
            return PartialView(sach);
        }


    }
}