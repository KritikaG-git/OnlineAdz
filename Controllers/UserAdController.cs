using Microsoft.AspNetCore.Mvc;
using OnlineAdz.Models;

namespace OnlineAdz.Controllers
{
    public class UserAdController : Controller
    {
        AdApplicationContext context = new AdApplicationContext();

        public ActionResult Index(string option, string search)
        {

            
            if (option == "Email")
            {
                 
                return View(context.UserAds.Where(x => x.Email == search).ToList());
            }
            else
            {
                return View(context.UserAds.Where(x => x.AdName == search).ToList());
            }
            
        }

        public IActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Create(UserAd ad)
        {
            if (ad != null)
            {
                context.UserAds.Add(ad);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int id)
        {
            
            
            return View(context.UserAds.Find(id));
            
        }
        [HttpPost]
        public IActionResult Edit(int id, UserAd ad)
        {
            
            
            if (ad != null)
            {
                UserAd a = context.UserAds.Find(id);
                a.CategoryId = ad.CategoryId;
                a.Email = ad.Email;
                a.AdName = ad.AdName;
                a.AdStatus = ad.AdStatus;
                a.UserInterest = ad.UserInterest;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
           
            return View();
            
        }

        public IActionResult Delete(int id)
        {
            return View(context.UserAds.Find(id));
        }
        [HttpPost]
        public IActionResult Delete(int id, UserAd ad)
        {
            if (ad != null)
            {
                UserAd a = context.UserAds.Find(id);
                context.UserAds.Remove(a);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Details(int id)
        {
            return View(context.UserAds.Find(id));
        }

    }
}
