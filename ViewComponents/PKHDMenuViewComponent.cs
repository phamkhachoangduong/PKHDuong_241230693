using Microsoft.AspNetCore.Mvc;
using PKHDuong_241230693.Models;

namespace PKHDuong_241230693.ViewComponents
{
    public class PKHDMenuViewComponent : ViewComponent

    {
        private readonly QLTaiSanContext _db;
        public PKHDMenuViewComponent(QLTaiSanContext db)
        {
            _db = db;
        }
        public IViewComponentResult Invoke() => View(_db.LoaiTaiSans.ToList());
    }
}
