using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers{
    public class About : Controller{
        public IActionResult Index(){
            return Content("index");
        }

        public IActionResult History(){
            return Content("history");
        }

        public IActionResult Location(){
            return Content("location");
        }
    }
}