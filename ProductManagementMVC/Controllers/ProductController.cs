using ProductManagementMVC.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ProductManagementMVC.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            var context = new QuanLySanPhamDataContext();
            List<Product> dsProducts = context.Products.ToList();
            return View(dsProducts);
        }
    }
}