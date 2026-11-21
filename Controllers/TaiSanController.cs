using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PKHDuong_241230693.Models;

namespace PKHDuong_241230693.Controllers
{
    public class TaiSanController : Controller
    {
        private readonly QLTaiSanContext _db;
        public TaiSanController(QLTaiSanContext db) { _db = db; }

        public IActionResult Create()
        {
            ViewBag.MaLoai = new SelectList(_db.LoaiTaiSans, "MaLoai", "TenLoai");
            return View();
        }

        [HttpPost]
        public IActionResult Create(TaiSan ts)
        {
            ModelState.Remove("MaLoaiNavigation");
            if (ModelState.IsValid)
            {
                _db.TaiSans.Add(ts);
                _db.SaveChanges();
                return RedirectToAction("Index", "Home", new { maLoai = ts.MaLoai });
            }
            ViewBag.MaLoai = new SelectList(_db.LoaiTaiSans, "MaLoai", "TenLoai", ts.MaLoai);
            return View(ts);
        }
    }
}