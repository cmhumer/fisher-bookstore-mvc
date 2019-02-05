using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers{
    [Route("books")]
    public class BooksController : Controller{
        [Route("")]
        [Route("index")]
        public IActionResult Index(){
            //return Content("This is the Books controller's Index action");
            return View("Books");
        }
        [Route("new")]
        public IActionResult New(){
            //return Content("This is the Books controller's New action");
            return View();
        }
        [Route("best-sellers")]
        public IActionResult Best(){
            //return Content("This is the Books controller's Best action with a route of 'books/best-sellers'");
            return View("Best");
        }
    }
}