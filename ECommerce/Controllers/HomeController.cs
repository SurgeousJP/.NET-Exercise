using ECommerce.ProductModels;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
    public class HomeController : Controller
    {
        private QlbanVaLiContext _db;

        public HomeController(QlbanVaLiContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var lstProduct = _db.TDanhMucSps.ToList();
            return View(lstProduct);
        }
    }
}
