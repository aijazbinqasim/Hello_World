using Microsoft.AspNetCore.Mvc;
using Hello_World.Models;
using System.Collections.Generic;

namespace Hello_World.Components
{
    public class ProgramingLangViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var plang = new PLang()
            {
                Names = new List<string> { 
                    "C#", 
                    "PHP", 
                    "JavaScript", 
                    "Java", 
                    "Dart", 
                    "JQuery", 
                    "Python" 
                }
            };

            return View("Plangs", plang);
        }
    }
}
