using System;
using Fisher.Bookstore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers{
    public class AuthorController : Controller{
        public IActionResult Index(){
            //return Content("Authors");
            return View("Index");
        }

        public IActionResult featured(){
            var featuredAuthor = new Author()
            {
                AuthorId = 1,
                Name = "J.K. Rowling"
            };
            return View(featuredAuthor);
        }
    }
}