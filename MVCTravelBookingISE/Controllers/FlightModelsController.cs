using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            var data = await _service.GetAllAsync();
            return View(data);
        }

        // GET: FlightModels/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var FlightDetails = await _service.GetByIdAsync(id);

            if (FlightDetails == null)
            {
                return View("Empty");
            }


            return View(FlightDetails);
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
            var flightModel = await _service.GetByIdAsync(id);
            if (flightModel == null)
            {
                return View("Not found");
            }
            return View(flightModel);

        }

        // POST: FlightModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Flight_Id,Flight_Destination,Flight_Departure,Flight_Date,Flight_Class,Flight_Rules_Id")] FlightModel flightModel)
        {
            if (id != flightModel.Flight_Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return View(flightModel);

            }
            await _service.UpdateAsync(id, flightModel);
            return RedirectToAction(nameof(Index));

        }

        // GET: FlightModels/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var flightModel = await _service.GetByIdAsync(id);

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
            var flightModel = await _service.GetByIdAsync(id);
            if (flightModel == null)
            {
                return View("Not found");
            }
            return View(flightModel);
        }

      

    }
}
