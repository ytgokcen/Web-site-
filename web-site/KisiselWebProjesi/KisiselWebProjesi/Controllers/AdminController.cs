using KisiselWebProjesi.Models.Siniflar;
using System.Linq;
using System.Web.Mvc;

namespace KisiselWebProjesi.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var deger = c.AnaSayfas.ToList();
            return View(deger);
        }

        public ActionResult AnaSayfaGetir(int id) 
        {
            var ag = c.AnaSayfas.Find(id);
            return View("AnaSayfaGetir", ag);
        }

        public ActionResult AnaSayfaGuncelle(AnaSayfa x)
        {
            var ag = c.AnaSayfas.Find(x.id);
            ag.isim = x.isim;
            ag.menugorsel = x.menugorsel; 
            ag.bilgi = x.bilgi;
            ag.marka = x.marka;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult ikonListesi()
        {
            var deger = c.İkonlars.ToList();
            return View(deger);
        }
        [HttpGet]
        public ActionResult YeniIkon()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniIkon(İkonlar p)
        {
            c.İkonlars.Add(p);
            c.SaveChanges();
            return RedirectToAction("ikonListesi");
        }

        public ActionResult ikonGetir(int id)
        {
            var ig = c.İkonlars.Find(id);
            return View("ikonGetir", ig);
        }

        public ActionResult ikonGuncelle(İkonlar x)
        {
            var ig = c.İkonlars.Find(x.id);
            ig.ikon = x.ikon;
            ig.link = x.link;
            c.SaveChanges();
            return RedirectToAction("ikonListesi");
        }

        public ActionResult ikonSil(int id)
        {
            var sl = c.İkonlars.Find(id);
            c.İkonlars.Remove(sl);
            c.SaveChanges();
            return RedirectToAction("ikonListesi");
        }

    }
}