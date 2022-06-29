using Microsoft.AspNetCore.Mvc;
using OnlineAdz.Models;

namespace OnlineAdz.Controllers
{
    public class UserInterestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(UserInterest ui)
        {
            string email = ui.Email;
            string categoryid = ui.CategoryId;
            string adname = ui.AdName;
            string addesc = ui.AdDesc;
            return View();
        }
    }
}
