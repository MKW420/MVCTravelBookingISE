using Microsoft.AspNetCore.Mvc;

namespace MVCTravelBookingISE.Controllers
{
    public class TravellerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
