using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers{
    public class AuthorController : Controller{
        public IActionResult Index(){
            //return Content("Authors");
            return View("Author");
        }

        public IActionResult Featured(){
            //return Content("Featured Authors");
            return View("Author");
        }
    }
}