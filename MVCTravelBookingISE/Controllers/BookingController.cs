using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVCTravelBookingISE.Models;

namespace MVCTravelBookingISE.Controllers
{
    public class BookingController : Controller
    {
        //GET:Home
        public IActionResult Index()
        {
            return View();
        }
        //HTTP GET VERSION
        public IActionResult Create()
        {
            return View();
        }

        //HTTP POST VERSION
        [HttpPost]
        public ActionResult Index(BookingModel booking)
        {
            int Booking_Id = booking.Booking_ID;
            string Booking_Name = booking.Booking_Name;
            DateTime Booking_DateTime = booking.Booking_date;

            return View();
            
        }


        public IActionResult Create(BookingController booking)
        {
            return View();

        }
    }
}
