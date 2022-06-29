using Microsoft.AspNetCore.Mvc;
using OnlineAdz.Models;

namespace OnlineAdz.Controllers
{
    public class CategoryAdController : Controller 
    {
        AdApplicationContext context = new AdApplicationContext();
        public IActionResult Index()
        {
            return View(context.CategoryAds.ToList());

        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CategoryAd cad)
        {
            if (cad != null)
            {
                context.CategoryAds.Add(cad);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(string id)
        {
            return View(context.CategoryAds.Find(id));
        }
        [HttpPost]
        public IActionResult Edit(string id,CategoryAd cad)
        {
           
            if (cad != null)
            {
                CategoryAd c = context.CategoryAds.Find(id);
                c.CategoryName = cad.CategoryName;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(string id)
        {
            return View(context.CategoryAds.Find(id));
        }
        [HttpPost]
        public IActionResult Delete(string id, CategoryAd cad)
        {
            if (cad != null)
            {
                CategoryAd c = context.CategoryAds.Find(id);
                context.CategoryAds.Remove(c);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Details(string id)
        {
            
            return View(context.CategoryAds.Find(id));
        }
    }
}
