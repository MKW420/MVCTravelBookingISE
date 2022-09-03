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
    public class TravellerModelsController : Controller
    {
        private readonly AppDbContext _context;

        public TravellerModelsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: TravellerModels
        public async Task<IActionResult> Index()
        {
              return _context.Traveller != null ? 
                          View(await _context.Traveller.ToListAsync()) :
                          Problem("Entity set 'AppDbContext.Travellers'  is null.");
        }

        // GET: TravellerModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Traveller== null)
            {
                return NotFound();
            }

            var travellerModel = await _context.Traveller
                .FirstOrDefaultAsync(m => m.Traveller_Id == id);
            if (travellerModel == null)
            {
                return NotFound();
            }

            return View(travellerModel);
        }

        // GET: TravellerModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TravellerModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Traveller_Id,First_Name,Last_Name,Email,Date_Of_Birth,Ratings")] TravellerModel travellerModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(travellerModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(travellerModel);
        }

        // GET: TravellerModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Traveller == null)
            {
                return NotFound();
            }

            var travellerModel = await _context.Traveller.FindAsync(id);
            if (travellerModel == null)
            {
                return NotFound();
            }
            return View(travellerModel);
        }

        // POST: TravellerModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Traveller_Id,First_Name,Last_Name,Email,Date_Of_Birth,Ratings")] TravellerModel travellerModel)
        {
            if (id != travellerModel.Traveller_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(travellerModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TravellerModelExists(travellerModel.Traveller_Id))
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
            return View(travellerModel);
        }

        // GET: TravellerModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Traveller == null)
            {
                return NotFound();
            }

            var travellerModel = await _context.Traveller
                .FirstOrDefaultAsync(m => m.Traveller_Id == id);
            if (travellerModel == null)
            {
                return NotFound();
            }

            return View(travellerModel);
        }

        // POST: TravellerModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Traveller == null)
            {
                return Problem("Entity set 'AppDbContext.Travellers'  is null.");
            }
            var travellerModel = await _context.Traveller.FindAsync(id);
            if (travellerModel != null)
            {
                _context.Traveller.Remove(travellerModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TravellerModelExists(int id)
        {
          return (_context.Traveller?.Any(e => e.Traveller_Id == id)).GetValueOrDefault();
        }
    }
}
