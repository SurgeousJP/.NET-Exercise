using AdminUserEcommerce.Models;
using AdminUserEcommerce.Models.Authentication;
using AdminUserEcommerce.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using X.PagedList;

namespace AdminUserEcommerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly QlbanVaLiContext _lbanVaLiContext;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _lbanVaLiContext = new QlbanVaLiContext();
        }

        [Authentication]
        public IActionResult Index(int? page)
        {
            int pageSize = 8;
            int pageNum = page == null || page < 0 ? 1 : page.Value;
            var products = _lbanVaLiContext.TDanhMucSps.AsNoTracking().OrderBy(x => x.TenSp);
            var lst = new PagedList<TDanhMucSp>(products, pageNum, pageSize);
            return View(lst);
        }

        [Authentication]
        public IActionResult SanPhamTheoLoai(string maLoai, int? page)
        {
            int pageSize = 8;
            int pageNum = page == null || page < 0 ? 1 : page.Value;
            var categories = _lbanVaLiContext.TDanhMucSps.Where(x => x.MaLoai == maLoai).OrderBy(x => x.TenSp).ToList();
            var lst = new PagedList<TDanhMucSp>(categories, pageNum, pageSize);
            ViewBag.maLoai = maLoai;
            return View(lst);
        }

        [Authentication]
        public IActionResult ChiTietSanPham(string maSp)
        {
            var sanPham = _lbanVaLiContext.TDanhMucSps.SingleOrDefault(x => x.MaSp == maSp);
            var anhSanPham = _lbanVaLiContext.TAnhSps.Where(x => x.MaSp == maSp).ToList();
            ViewBag.anhSanPham = anhSanPham;
            return View(sanPham);
        }

        [Authentication]
        public IActionResult ProductDetail(string maSp)
        {
            var sanPham = _lbanVaLiContext.TDanhMucSps.SingleOrDefault(x => x.MaSp == maSp);
            var anhSanPham = _lbanVaLiContext.TAnhSps.Where(x => x.MaSp == maSp).ToList();
            var homeProductDetailViewModel = new HomeProductDetailViewModel
            {
                danhMucSp = sanPham,
                anhSps = anhSanPham
            };
            return View(homeProductDetailViewModel);
        }


        public IActionResult Privacy()
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
