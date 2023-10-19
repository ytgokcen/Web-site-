using System.Linq;
using System.Web.Mvc;

namespace KisiselWebProjesi.Controllers
{
    public class AnaSayfaController : Controller
    {
        Context c = new Context();

        public ActionResult Index()
        {
            var deger = c.AnaSayfas.ToList();
            return View(deger);
        }

        public ActionResult About()
        {
            var deger = c.İkonlars.ToList();
            return View(deger);
        }

        public PartialViewResult İkonlar()
        {
            var iconData = c.İkonlars.ToList();
            return PartialView(iconData);
        }
    }
}