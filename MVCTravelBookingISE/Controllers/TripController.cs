using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCTravelBookingISE.Data;
using MVCTravelBookingISE.Data.Services;
using MVCTravelBookingISE.Data.ViewModels;

namespace MVCTravelBookingISE.Controllers
{
    public class TripController : Controller
    {

        private readonly ITripService _service;


        public TripController(TripService service)
        {
          _service = service;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
        //   var id = User.Identity.Get
            var allTrip = await _service.GetAllAsync(n => n.bookedAccoItem);
            return View(allTrip);
        }

        //GET: Trip Info
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var TripDetails = await _service.GetTripByIdAsync(id);
            return View(TripDetails);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Create(TripVM trip)
        {
            if (!ModelState.IsValid)
            {
                return View(trip);
            }

            await _service.AddNewTripAsync(trip);
            return RedirectToAction(nameof(Index));
        }

    }
}
