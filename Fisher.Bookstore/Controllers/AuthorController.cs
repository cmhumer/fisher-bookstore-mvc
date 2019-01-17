using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers{
    public class AuthorController : Controller{
        public IActionResult Index(){
            return Content("Authors");
        }

        public IActionResult Featured(){
            return Content("Featured Authors");
        }
    }
}