using AdminUserEcommerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdminUserEcommerce.Controllers
{
    public class AccessController : Controller
    {
        private readonly QlbanVaLiContext _context;

        public AccessController()
        {
            _context = new QlbanVaLiContext();
        }

        [HttpGet]
        public IActionResult Login()
        {
            if (HttpContext.Session.GetString("UserName") == null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        public IActionResult Login(TUser user)
        {
            if (HttpContext.Session.GetString("UserName") == null)
            {
                var u = _context.TUsers.Where(x => x.Username.Equals(user.Username) && x.Password.Equals(user.Password)).FirstOrDefault();

                if (u != null)
                {
                    HttpContext.Session.SetString("UserName", u.Username.ToString());
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            HttpContext.Session.Remove("UserName");
            return RedirectToAction("Login", "Access");
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
