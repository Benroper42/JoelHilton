using System.Diagnostics;
using JoelHilton.Models;
using Microsoft.AspNetCore.Mvc;

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
            return View();
        }

        [HttpPost]
        public IActionResult MovieForm(Application response)
        {
            _context.Application.Add(response); // Add record to database
            _context.SaveChanges();
            return View("Confirmation");
        }

        public IActionResult AboutJoel()
        {
            return View();
        }
    }
}
