using BusinessLayer.Concrete;
using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Morgoth.Controllers
{
    public class AdminPageController : Controller
    {
        AnimeManager am = new AnimeManager(new EfAnimeRepository());
        Context c = new Context();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AnimeAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AnimeAdd(Anime p)
        {
           am.TAdd(p);
            return View();
        }
        public IActionResult AnimeDelete(int id)
        {
            var animevalue = am.TGetById(id);
                am.TDelete(animevalue);
            return RedirectToAction("AnimeList");
        }

        [HttpGet]
        public IActionResult AnimeUpdate(int id)
        {
            var stockvalue = am.TGetById(id);

            List<SelectListItem> values = (from x in am.GetList()
                                           select new SelectListItem
                                           {
                                               Text = x.AnimeName,
                                               Value = x.AnimeID.ToString()
                                           }).ToList();
            ViewBag.cv = values;

            return View(stockvalue);
        }
        [HttpPost]
        public IActionResult AnimeUpdate(Anime p)
        {

            am.TUpdate(p);
            return RedirectToAction("Index");
        }

        public IActionResult AnimeList()
        {
            var values = am.GetList();
            return View(values);
        }
    }
}
