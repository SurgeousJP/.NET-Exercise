using ProductManagementMVC.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ProductManagementMVC.Controllers
{
    public class CatalogController : Controller
    {
        // GET: Catalog
        public ActionResult Index()
        {
            var context = new QuanLySanPhamDataContext();
            List<Catalog> dsCatalog = context.Catalogs.ToList();
            return View(dsCatalog);
        }

    }
}