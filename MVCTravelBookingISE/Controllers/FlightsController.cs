using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVCTravelBookingISE.Data.Services;
using MVCTravelBookingISE.Models;

namespace MVCTravelBookingISE.Controllers
{
    public class FlightsController : Controller
    {
        private readonly IFlightsService _service;

        public FlightsController(IFlightsService service)
        {
            _service = service;
        }

        // GET: FlightModels
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        // GET: FlightModels/Details/5

        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var FlightDetails = await _service.GetFlightsByIdAsync(id);

            if (FlightDetails == null)
            {
                return View("Empty");
            }


            return View(FlightDetails);
        }
        [AllowAnonymous]
        public async Task<IActionResult> Filter(string searchDes, string searchDep, DateTime dateflight)
        {
            var allTransport = await _service.GetAllAsync();

            if (!string.IsNullOrEmpty(searchDep))
            {
                var filterResult = allTransport.Where(n => string.Equals(n.Flight_Departure,   searchDep) || n.Flight_Destination.Contains(searchDes)).ToList();
                return View("Index", filterResult);

            }
            return View("Index", allTransport);
        }




        // GET: FlightModels/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var FlightDetails = await _service.GetFlightsByIdAsync(id);

            if (FlightDetails == null) return View("NotFound");

            var response = new Flights()
            {
                Id = FlightDetails.Id,
                Airline = FlightDetails.Airline,
                Flight_Destination = FlightDetails.Flight_Destination,
                Flight_Departure = FlightDetails.Flight_Departure,
                Flight_Date = FlightDetails.Flight_Date,
                Flight_Price = FlightDetails.seats,
                Flight_Class = FlightDetails.Flight_Class


            };
            return View(response);
        }

        [HttpPost]

        // GET: AccomodationModels/Edit/5
        public async Task<IActionResult> Edit(int id, Flights flight)
        {

            if (id != flight.Id) return View("Not found");

            if (!ModelState.IsValid)
            {
                return View(flight);
            }

            await _service.UpdateFlightAsync(flight);
            return RedirectToAction(nameof(Index));
        }






    }
}