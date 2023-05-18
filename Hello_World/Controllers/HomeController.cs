using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

namespace Hello_World.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _config;

        public HomeController(IConfiguration config)
        {
            _config = config;
        }

        public ViewResult Index()
        {

            //var isUserAccount = _config["Person:IsUserAccount"];
            //var name = _config["Person:Bio:Name"];


            var isUserAccount = _config.GetValue<bool>("Person:IsUserAccount");
            var name = _config["Person:Bio:Name"];

            //var hobbies = _config.GetValue<List<string>>("Person:Bio:Hobbies");

           // var hobbies = _config.GetSection("Person:Bio:Hobbies").Get<Array>();
            ViewBag.Hobbies = _config.GetSection("Person:Bio:Hobbies").Get<List<string>>();

            ViewBag.IsUserAccount = isUserAccount;
            ViewBag.Name = name;

            //ViewBag.Name = _config["Name"];

            //ViewBag.Name = _config.GetValue<string>("Name");

            //var age = _config.GetValue<int>("Age");

            //var isSync = _config.GetValue<bool>("IsSync");


            //ViewBag.Age = age;
            //ViewBag.IsSync = isSync;


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
