using Microsoft.AspNetCore.Mvc;

namespace MVCTravelBookingISE.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
