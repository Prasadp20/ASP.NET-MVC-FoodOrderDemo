using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ASP.NET_MVC_Demo.Models;

namespace ASP.NET_MVC_Demo.Controllers
{
    public class Sign_UpController : Controller
    {
        public IActionResult Sign_Up()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Sign_Up(IFormCollection form)
        {
            ViewBag.First_Name = form["first_name"];
            ViewBag.Last_Name = form["last_name"];
            ViewBag.Username = form["username"];
            ViewBag.Password = form["password"];
            return View("Sign_In");
        }
    }
}
