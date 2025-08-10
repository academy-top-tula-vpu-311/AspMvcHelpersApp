using System.Diagnostics;
using AspMvcHelpersApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AspMvcHelpersApp.Controllers
{
    public class HomeController : Controller
    {
        string[] cities = { "Moscow", "St Petersburg", "Novosibirsk" };
        string[] users = { "Kenny", "Jimmy", "Sammy", "Poppy" };
        string[] languages = { "english", "russian", "chines", "deutchen" };

        public IActionResult Index()
        {
            return View(new { Cities = cities, Users = users });
        }

        public new IActionResult User()
        {
            User user = new User()
            {
                Id = 12,
                Name = "Bobby",
                Age = 32,
                Gender = Gender.Male,
                Languages = new() { "Russian", "English" }
            };

            ViewBag.Languages = new SelectList(languages);
            //return View(user);
            //return View("UserModel", user);
            //return View("UserEdit", user);
            return View("UserTag");
        }

        public IActionResult Second()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        
    }
}
