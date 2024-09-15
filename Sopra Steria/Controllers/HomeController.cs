using Microsoft.AspNetCore.Mvc;
using Sopra_Steria.Models;
using System.Diagnostics;

namespace Sopra_Steria.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        /*public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        */
        //vi har kommet med objekten fra NewsDB som er i programs.cs
        NewsDB db;
        //vi har laget kostruktør til å kunne bruke objekten db 
        public HomeController(NewsDB context) {
            db = context;
        }

        public IActionResult Index()
        {
            var result= db.Categories.ToList();
            return View(result);
        }

        [HttpGet]
        public IActionResult ContactUs()
        {
      
            return View();
        }
        [HttpPost]
        public IActionResult send(ContactUs model)
        {
            db.ContactUs.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
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
