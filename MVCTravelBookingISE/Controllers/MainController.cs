using Microsoft.AspNetCore.Mvc;

namespace MVCTravelBookingISE.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
