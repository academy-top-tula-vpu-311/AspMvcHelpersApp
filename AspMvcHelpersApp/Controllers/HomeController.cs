using System.Diagnostics;
using AspMvcHelpersApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspMvcHelpersApp.Controllers
{
    public class HomeController : Controller
    {
        string[] cities = { "Moscow", "St Petersburg", "Novosibirsk" };
        string[] users = { "Kenny", "Jimmy", "Sammy", "Poppy" };

        public IActionResult Index()
        {
            return View(new { Cities = cities, Users = users });
        }

        public IActionResult User()
        {
            User user = new User()
            {
                Id = 1,
                Name = "Lenny",
                Age = 28,
                Gender = Gender.Male,
                Languages = new() { "Russian", "English" }
            };

            return View(user);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        
    }
}
