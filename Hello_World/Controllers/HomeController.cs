using Microsoft.AspNetCore.Mvc;

namespace Hello_World.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        //public string Index(int? id)
        //{
        //    return $"Hello Index() MVC {id}";
        //}

        public IActionResult About()
        {
            return View();
        }

        public ViewResult Contact()
        {
            ViewBag.Title = "Contact";
            return View();
        }

        [HttpPost]
        public ViewResult Contact(string name, string email)
        {
            ViewBag.Name = name;
            ViewBag.Email = email;

            return View();
        }

        [HttpPost]
        public ViewResult ContactUs()
        {
            ViewBag.Name = HttpContext.Request.Form["name"];
            ViewBag.Email = HttpContext.Request.Form["email"];

            return View("Contact");
        }
    }
}
