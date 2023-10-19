using KisiselWebProjesi.Models.Siniflar;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;

namespace KisiselWebProjesi.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin ad)
        {
            string kullaniciAdi = ad.kullaniciadi.ToString();
            string sifre = ad.sifre.ToString();

            var bilgiler = c.Admins.FirstOrDefault(x => x.kullaniciadi == kullaniciAdi && x.sifre== sifre);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.kullaniciadi, false);
                Session["kullaniciadi"] = bilgiler.kullaniciadi.ToString();
                return RedirectToAction("Index", "Admin");

            }
            else
            {
                return View();
            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }

    }
}