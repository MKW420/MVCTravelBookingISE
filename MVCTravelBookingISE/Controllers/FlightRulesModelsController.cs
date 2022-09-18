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
    public class FlightRulesModelsController : Controller
    {
        private readonly AppDbContext _context;

        public FlightRulesModelsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: FlightRulesModels
        public async Task<IActionResult> Index()
        {
              return _context.FlightRule != null ? 
                          View(await _context.FlightRule.ToListAsync()) :
                          Problem("Entity set 'AppDbContext.FlightRules'  is null.");
       
        }

        // GET: FlightRulesModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.FlightRule == null)
            {
                return NotFound();
            }

            var flightRulesModel = await _context.FlightRule
                .FirstOrDefaultAsync(m => m.FlightRules_Id == id);
            if (flightRulesModel == null)
            {
                return NotFound();
            }

            return View(flightRulesModel);
        }

        // GET: FlightRulesModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FlightRulesModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FlightRules_Id,Flight_Descrip,Flight_Name")] FlightRulesModel flightRulesModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(flightRulesModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(flightRulesModel);
        }

        // GET: FlightRulesModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.FlightRule == null)
            {
                return NotFound();
            }

            var flightRulesModel = await _context.FlightRule.FindAsync(id);
            if (flightRulesModel == null)
            {
                return NotFound();
            }
            return View(flightRulesModel);
        }

        // POST: FlightRulesModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FlightRules_Id,Flight_Descrip,Flight_Name")] FlightRulesModel flightRulesModel)
        {
            if (id != flightRulesModel.FlightRules_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(flightRulesModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FlightRulesModelExists(flightRulesModel.FlightRules_Id))
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
            return View(flightRulesModel);
        }

        // GET: FlightRulesModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.FlightRule == null)
            {
                return NotFound();
            }

            var flightRulesModel = await _context.FlightRule
                .FirstOrDefaultAsync(m => m.FlightRules_Id == id);
            if (flightRulesModel == null)
            {
                return NotFound();
            }

            return View(flightRulesModel);
        }

        // POST: FlightRulesModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.FlightRule == null)
            {
                return Problem("Entity set 'AppDbContext.FlightRules'  is null.");
            }
            var flightRulesModel = await _context.FlightRule.FindAsync(id);
            if (flightRulesModel != null)
            {
                _context.FlightRule.Remove(flightRulesModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FlightRulesModelExists(int id)
        {
          return (_context.FlightRule?.Any(e => e.FlightRules_Id == id)).GetValueOrDefault();
        }
    }
}
