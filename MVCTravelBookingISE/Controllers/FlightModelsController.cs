using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCTravelBookingISE.Data;
using MVCTravelBookingISE.Models;

namespace MVCTravelBookingISE.Controllers
{
    public class FlightModelsController : Controller
    {
        private readonly AppDbContext _context;

        public FlightModelsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: FlightModels
        public async Task<IActionResult> Index()
        {
              return _context.Flights != null ? 
                          View(await _context.Flights.ToListAsync()) :
                          Problem("Entity set 'AppDbContext.Flights'  is null.");
        }

        // GET: FlightModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Flights == null)
            {
                return NotFound();
            }

            var flightModel = await _context.Flights
                .FirstOrDefaultAsync(m => m.Flight_Id == id);
            if (flightModel == null)
            {
                return NotFound();
            }

            return View(flightModel);
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
                _context.Add(flightModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(flightModel);
        }

        // GET: FlightModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Flights == null)
            {
                return NotFound();
            }

            var flightModel = await _context.Flights.FindAsync(id);
            if (flightModel == null)
            {
                return NotFound();
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

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(flightModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FlightModelExists(flightModel.Flight_Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(flightModel);
        }

        // GET: FlightModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Flights == null)
            {
                return NotFound();
            }

            var flightModel = await _context.Flights
                .FirstOrDefaultAsync(m => m.Flight_Id == id);
            if (flightModel == null)
            {
                return NotFound();
            }

            return View(flightModel);
        }

        // POST: FlightModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Flights == null)
            {
                return Problem("Entity set 'AppDbContext.Flights'  is null.");
            }
            var flightModel = await _context.Flights.FindAsync(id);
            if (flightModel != null)
            {
                _context.Flights.Remove(flightModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FlightModelExists(int id)
        {
          return (_context.Flights?.Any(e => e.Flight_Id == id)).GetValueOrDefault();
        }
    }
}
