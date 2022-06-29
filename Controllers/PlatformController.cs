using Microsoft.AspNetCore.Mvc;
using OnlineAdz.Models;

namespace OnlineAdz.Controllers
{
    public class PlatformController : Controller
    {
        popularityContext context = new popularityContext();
        public IActionResult Index()
        {
            return View(context.Platforms.ToList());
        }
        

    }
}
