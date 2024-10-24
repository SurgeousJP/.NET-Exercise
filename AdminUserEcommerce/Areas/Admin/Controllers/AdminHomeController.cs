using AdminUserEcommerce.Models;
using AdminUserEcommerce.Models.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using X.PagedList;

namespace AdminUserEcommerce.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("homeadmin")]
    public class AdminHomeController : Controller
    {
        QlbanVaLiContext _context;
        private readonly ILogger<AdminHomeController> _logger;

        public AdminHomeController(ILogger<AdminHomeController> logger)
        {
            _context = new QlbanVaLiContext();
            _logger = logger;
        }

        [Authentication]
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }

        [Authentication]
        [Route("danhmucsanpham")]
        public IActionResult DanhMucSanPham(int? page)
        {
            int pageSize = 8;
            int pageNumber = page == null || page < 0 ? 1 : page.Value;
            var lstSanPham = _context.TDanhMucSps.ToList();
            PagedList<TDanhMucSp> lst = new PagedList<TDanhMucSp>(lstSanPham, pageNumber, pageSize);
            return View(lst);
        }

        [Authentication]
        [Route("ThemSanPhamMoi")]
        [HttpGet]
        public IActionResult ThemSanPhamMoi()
        {
            ViewBag.MaChatLieu = new SelectList(_context.TChatLieus.ToList(), "MaChatLieu", "ChatLieu");
            ViewBag.MaHangSx = new SelectList(_context.THangSxes.ToList(), "MaHangSx", "HangSx");
            ViewBag.MaNuocSx = new SelectList(_context.TQuocGia.ToList(), "MaNuoc", "TenNuoc");
            ViewBag.MaLoai = new SelectList(_context.TLoaiSps.ToList(), "MaLoai", "Loai");
            ViewBag.MaDt = new SelectList(_context.TLoaiDts.ToList(), "MaDt", "TenLoai");
            return View();
        }

        [Authentication]
        [Route("ThemSanPhamMoi")]
        [HttpPost]
        public IActionResult ThemSanPhamMoi(TDanhMucSp model)
        {
            if (ModelState.IsValid)
            {
                // Save the product to the database or perform any action
                _context.TDanhMucSps.Add(model);
                _context.SaveChanges();
                return RedirectToAction("DanhMucSanPham", "HomeAdmin", new { area = "Admin" });
            }
            // Return the view with model state errors
            return View(model);
        }

        [Authentication]
        [Route("SuaSanPham")]
        [HttpGet]
        public IActionResult SuaSanPham(string maSanPham)
        {
            ViewBag.MaChatLieu = new SelectList(_context.TChatLieus.ToList(), "MaChatLieu", "ChatLieu");
            ViewBag.MaHangSx = new SelectList(_context.THangSxes.ToList(), "MaHangSx", "HangSx");
            ViewBag.MaNuocSx = new SelectList(_context.TQuocGia.ToList(), "MaNuoc", "TenNuoc");
            ViewBag.MaLoai = new SelectList(_context.TLoaiSps.ToList(), "MaLoai", "Loai");
            ViewBag.MaDt = new SelectList(_context.TLoaiDts.ToList(), "MaDt", "TenLoai");
            var sanPham = _context.TDanhMucSps.Find(maSanPham);
            return View(sanPham);
        }

        [Authentication]
        [Route("SuaSanPham")]
        [HttpPost]
        public IActionResult SuaSanPham(TDanhMucSp sanPham)
        {
            if (ModelState.IsValid)
            {
                // Save the product to the database or perform any action
                _context.TDanhMucSps.Update(sanPham);
                _context.SaveChanges();
                return RedirectToAction("DanhMucSanPham", "HomeAdmin", new { area = "Admin" });
            }

            // Return the view with model state errors
            return View(sanPham);
        }

        [Authentication]
        [Route("XoaSanPham")]
        [HttpGet]
        public IActionResult XoaSanPham(string maSanPham)
        {
            TempData["Message"] = "";
            var chiTietSanPham = _context.TChiTietSanPhams.Where(x => x.MaSp == maSanPham).ToList();
            if (chiTietSanPham.Count() > 0)
            {
                TempData["Message"] = "Không xóa được sản phẩm này";
                return RedirectToAction("DanhMucSanPham", "HomeAdmin", new { area = "Admin" });
            }
            var anhSanPhams = _context.TAnhSps.Where(x => x.MaSp == maSanPham).ToList();
            if (anhSanPhams.Any())
            {
                _context.RemoveRange(anhSanPhams);
            }

            var sp = _context.TDanhMucSps.Where(x => x.MaSp == maSanPham).FirstOrDefault();

            if (sp != null)
            {
                _context.Remove(sp);
            }

            _context.SaveChanges();
            TempData["Message"] = "Sản phẩm đã được xóa";
            return RedirectToAction("DanhMucSanPham", "HomeAdmin", new { area = "Admin" });
        }
    }
}
