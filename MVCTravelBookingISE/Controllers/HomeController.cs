using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVCTravelBookingISE.Models;
using System.Diagnostics;

namespace MVCTravelBookingISE.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


       
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [AllowAnonymous]

        public IActionResult Index()
        {
            
            return View();
           
        }

    

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
        [AllowAnonymous]

        public IActionResult Privacy()
        {
            return View();
        }
        [AllowAnonymous]

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}