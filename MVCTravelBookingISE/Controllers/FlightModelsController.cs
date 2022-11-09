using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCTravelBookingISE.Data;
using MVCTravelBookingISE.Data.Services;
using MVCTravelBookingISE.Models;

namespace MVCTravelBookingISE.Controllers
{
    public class FlightModelsController : Controller
    {
        private readonly IFlightService _service;
       
        public FlightModelsController(IFlightService service)
        {
            _service = service;
        }

        // GET: FlightModels
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync(n => n.FlightRule);
            return View(data);
        }

        // GET: FlightModels/Details/5
        
        public async Task<IActionResult> Details(int id)
        {
            var FlightDetails = await _service.GetFlightsByIdAsync(id);

            if (FlightDetails == null)
            {
                return View("Empty");
            }


            return View(FlightDetails);
        }
        public async Task<IActionResult> Filter(string searchDes, string searchDep, DateTime dateflight)
        {
            var allTransport = await _service.GetAllAsync();

            if (!string.IsNullOrEmpty(searchDep))
            {
                var filterResult = allTransport.Where(n => n.Flight_Departure.Contains(searchDep) || n.Flight_Destination.Contains(searchDes)).ToList();
                return View("Index", filterResult);

            }
            return View("Index", allTransport);
        }
        // GET: FlightModels/Create
        public IActionResult Create()
        {

            return View();
        }

        // POST: FlightModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Flight_Id,Flight_Destination,Flight_Departure,Flight_Date,Flight_Class,Flight_Rules_Id")] FlightModel flightModel)
        {
            if (ModelState.IsValid)
            {
                await _service.AddSync(flightModel);


                return RedirectToAction(nameof(Index));
            }
            return View(flightModel);
        }

        // GET: FlightModels/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var FlightDetails = await _service.GetFlightsByIdAsync(id);

            if (FlightDetails == null) return View("NotFound");

            var response = new FlightModel()
            {
                Flight_Id = FlightDetails.Flight_Id,
                Flight_Class = FlightDetails.Flight_Class,
                ToDate = FlightDetails.ToDate,
                FromDate = FlightDetails.FromDate,
                Flight_Destination = FlightDetails.Flight_Destination,
                Flight_Departure = FlightDetails.Flight_Departure,
                Flight_Price = FlightDetails.Flight_Price,
                FlightRules_Id = FlightDetails.FlightRules_Id

            };
            return View(response);
        }

        [HttpPost]

        // GET: AccomodationModels/Edit/5
        public async Task<IActionResult> Edit(int id, FlightModel flight)
        {

            if (id != flight.Flight_Id) return View("Not found");

            if (!ModelState.IsValid)
            {
                return View(flight);
            }

            await _service.UpdateFlightAsync(flight);
            return RedirectToAction(nameof(Index));
        }


        // GET: FlightModels/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var flightModel = await _service.GetFlightsByIdAsync(id);

            if (flightModel == null)
            {
                return View("Not found");
            }
            return View(flightModel);

        }

        // POST: FlightModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var flightModel = await _service.GetFlightsByIdAsync(id);
            if (flightModel == null)
            {
                return View("Not found");
            }
            return View(flightModel);
        }

      

    }
}
