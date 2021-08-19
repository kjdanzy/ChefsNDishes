using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ChefsNDishes.Models;
using Microsoft.EntityFrameworkCore;

namespace ChefsNDishes.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;

        public HomeController(MyContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public IActionResult Chefs()
        {
            ViewBag.Chefs = _context.Chefs
                .Include(dish => dish.Dishes)
                .ToList();

            return View();
        }

        [HttpGet("newchef")]
        public IActionResult NewChef()
        {
            return View();
        }

        [HttpPost("savechef")]
        public IActionResult SaveChef(Chef newChef)
        {

            if (ModelState.IsValid)
            {
                _context.Add(newChef);
                _context.SaveChanges();
                return RedirectToAction("Chefs");
            }
            Console.WriteLine(newChef.FirstName);
            return View("NewChef", newChef);
        }

        
        [HttpGet("dishes")]
        public IActionResult Dishes()
        {
            ViewBag.Dishes = _context.Dishes
                .Include(dish => dish.DishCreator)
                .ToList();

            return View();
        }


        [HttpGet("newdish")]
        public IActionResult NewDish()
        {
            ViewBag.Chefs = _context.Chefs
                .ToList();

            return View();
        }

        [HttpPost("savedish")]
        public IActionResult SaveDish(Dish newDish)
        {

            if (ModelState.IsValid)
            {
                _context.Add(newDish);
                _context.SaveChanges();
                return RedirectToAction("Dishes");
            }
            Console.WriteLine(newDish.Name);
            return View("NewDish");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
