using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ASP.NET_MVC_Demo.Models;
using System.Collections.Generic;

namespace ASP.NET_MVC_Demo.Controllers
{
    public class Sign_InController : Controller
    {
        public IActionResult Sign_In()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Sign_In(IFormCollection form)
        {
            ViewBag.Username = form["Username"];
            ViewBag.Password = form["Password"];
            return View("Welcome");
        }

        public IActionResult List()
        {
            List<MenuList> list1 = new List<MenuList>()
            {
                new MenuList { SrNo = 1, fooditem = "Burgur", price = 200.50 },
                new MenuList { SrNo = 2, fooditem = "Dhokla", price = 90.45 },
                new MenuList { SrNo = 3, fooditem = "Veg Cutlet", price = 110.55 },
                new MenuList { SrNo = 4, fooditem = "French fries", price = 110.45 },
                new MenuList { SrNo = 5, fooditem = "Batata Veda", price = 25.45 },
                new MenuList { SrNo = 6, fooditem = "Veg Kabab", price = 125.25},
            };

            List<MenuList> list2 = new List<MenuList>()
            {
                new MenuList { SrNo = 1, fooditem = "Coffee", price = 50.50 },
                new MenuList { SrNo = 2, fooditem = "Tea", price = 40.45 },
                new MenuList { SrNo = 3, fooditem = "Cold Coffee", price = 65.55 },
                new MenuList { SrNo = 4, fooditem = "Green Tea", price = 45.45 },
                new MenuList { SrNo = 5, fooditem = "Orange Jouice", price = 30.45 },
                new MenuList { SrNo = 6, fooditem = "Milk Shake", price = 70.25},
            };

            ViewBag.SnaksList = list1;
            ViewBag.DrinksList = list2;
            return View();
        }

        public IActionResult OrderDetails()
        {
            return View();
        }

        [HttpPost]
        public IActionResult List(ICollection<string> Snaks, ICollection<string> Drinks)
        {
            ViewBag.fooditem1 = Snaks;
            ViewBag.fooditem2 = Drinks;
            return View("OrderDetails");
        }
    }
}
