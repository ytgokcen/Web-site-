using KisiselWebProjesi.Models.Siniflar;
using System.Data.Entity;
using System.Web.Mvc;

namespace KisiselWebProjesi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }

    public class Context : DbContext
    {
        public DbSet<AnaSayfa> AnaSayfas { get; set; }
        public DbSet<İkonlar> İkonlars { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}