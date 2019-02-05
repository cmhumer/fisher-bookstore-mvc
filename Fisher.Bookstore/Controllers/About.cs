using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers{
    public class About : Controller{
        public IActionResult Index(){
            //return Content("index");
            return View("About");
        }

        public IActionResult History(){
            //return Content("history");
            return View();
        }

        public IActionResult Location(){
            //return Content("location");
            return View();
        }
    }
}