using Microsoft.AspNetCore.Mvc;

namespace MVCTravelBookingISE.Controllers
{
    public class FlightController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
