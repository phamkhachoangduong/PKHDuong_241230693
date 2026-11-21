using Microsoft.AspNetCore.Mvc;
using PKHDuong_241230693.Models;
using System.Diagnostics;

namespace PKHDuong_241230693.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly QLTaiSanContext _db;
        public HomeController(QLTaiSanContext db) {  _db = db; }

        public IActionResult Index(int? maloai)
        {
            if (maloai !=null)
            {
                ViewBag.TieuDe = _db.LoaiTaiSans.Find(maloai)?.TenLoai;
               return View(_db.TaiSans.Where(t => t.MaLoai == maloai).ToList());
            }
            ViewBag.TieuDe = "Pham Khac Hoang Duong";
            return View(_db.TaiSans.Where(t => t.NguyenGia >=20).ToList());
        }

        public IActionResult LocTheoLoai(int maloai)
        {
            ViewBag.TieuDe = _db.LoaiTaiSans.Find(maloai)?.TenLoai;
            return PartialView("PKHDMainContent", _db.TaiSans.Where(t => t.MaLoai ==maloai).ToList())  ;
        }

      
    }
}
