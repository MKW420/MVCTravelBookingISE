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
    public class AccomodationModelsController : Controller
    {
        private readonly AppDbContext _context;

        public AccomodationModelsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: AccomodationModels
        public async Task<IActionResult> Index()
        {
              return _context.Accomodation != null ? 
                          View(await _context.Accomodation.ToListAsync()) :
                          Problem("Entity set 'AppDbContext.Accomodations'  is null.");
        }

        // GET: AccomodationModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Accomodation == null)
            {
                return NotFound();
            }

            var accomodationModel = await _context.Accomodation
                .FirstOrDefaultAsync(m => m.Acco_Id == id);
            if (accomodationModel == null)
            {
                return NotFound();
            }

            return View(accomodationModel);
        }

        // GET: AccomodationModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AccomodationModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Acco_Id,Acco_Name,Acco_Destination,Acco_Rooms,Acco_Bathrooms,Acco_Distance,Acco_Rate,Acco_Type,Acco_Price")] AccomodationModel accomodationModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(accomodationModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(accomodationModel);
        }

        // GET: AccomodationModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Accomodation == null)
            {
                return NotFound();
            }

            var accomodationModel = await _context.Accomodation.FindAsync(id);
            if (accomodationModel == null)
            {
                return NotFound();
            }
            return View(accomodationModel);
        }

        // POST: AccomodationModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Acco_Id,Acco_Name,Acco_Destination,Acco_Rooms,Acco_Bathrooms,Acco_Distance,Acco_Rate,Acco_Type,Acco_Price")] AccomodationModel accomodationModel)
        {
            if (id != accomodationModel.Acco_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(accomodationModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccomodationModelExists(accomodationModel.Acco_Id))
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
            return View(accomodationModel);
        }

        // GET: AccomodationModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Accomodation == null)
            {
                return NotFound();
            }

            var accomodationModel = await _context.Accomodation
                .FirstOrDefaultAsync(m => m.Acco_Id == id);
            if (accomodationModel == null)
            {
                return NotFound();
            }

            return View(accomodationModel);
        }

        // POST: AccomodationModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Accomodation == null)
            {
                return Problem("Entity set 'AppDbContext.Accomodations'  is null.");
            }
            var accomodationModel = await _context.Accomodation.FindAsync(id);
            if (accomodationModel != null)
            {
                _context.Accomodation.Remove(accomodationModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AccomodationModelExists(int id)
        {
          return (_context.Accomodation?.Any(e => e.Acco_Id == id)).GetValueOrDefault();
        }
    }
}
