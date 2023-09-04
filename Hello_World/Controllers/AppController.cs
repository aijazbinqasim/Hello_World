using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hello_World.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetString("_UserName", "Aijaz Ali Abro Session");
            HttpContext.Session.SetInt32("_Age", 30);

            return View();
        }

        public IActionResult About()
        {
            return View();
        }

    }
}
