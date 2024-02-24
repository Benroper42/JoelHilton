using System.Diagnostics;
using JoelHilton.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JoelHilton.Controllers
{
    public class HomeController : Controller
    {

        private MovieFormContext _context;

        public HomeController(MovieFormContext temp) //Constructor
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieForm()
        {
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();

            return View();
        }

        [HttpPost]
        public IActionResult MovieForm(Application response)
        {
            _context.Movies.Add(response); // Add record to database
            _context.SaveChanges();
            return View("Confirmation");
        }

       public IActionResult WaitList()
        {
            var movies = _context.Movies.Include("Category")
                .ToList();

            return View(movies);
        }

        public IActionResult AboutJoel()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Application recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();

            return View("MovieForm", recordToEdit);
        }
        [HttpPost]
        public IActionResult Edit(Application updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();

            return RedirectToAction("WaitList");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);

             return View(recordToDelete);
        }
        [HttpPost]
        public IActionResult Delete(Application application)
        {
            _context.Movies.Remove(application);
            _context.SaveChanges();

            return RedirectToAction("WaitList");
        }
    }
}
