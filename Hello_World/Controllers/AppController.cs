using Hello_World.Extensions;
using Hello_World.Models;
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

            Person person = new() { Name = "Aijaz", Age = 30, Amount = 5000m };
            HttpContext.Session.Set("_Person", person);

            HttpContext.Session.Set("_bool", true);


            return View();
        }


        public ViewResult ClearSession()
        {
           // HttpContext.Session.Remove("_Age");

            HttpContext.Session.Clear();
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

    }
}
