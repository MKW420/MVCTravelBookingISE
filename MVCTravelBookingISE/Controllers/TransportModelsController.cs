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
    public class TransportModelsController : Controller
    {
        private readonly AppDbContext _context;

        public TransportModelsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: TransportModels
        public async Task<IActionResult> Index()
        {
              return _context.Transports != null ? 
                          View(await _context.Transports.ToListAsync()) :
                          Problem("Entity set 'AppDbContext.transports'  is null.");
        }

        // GET: TransportModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Transports == null)
            {
                return NotFound();
            }

            var transportModel = await _context.Transports
                .FirstOrDefaultAsync(m => m.Transport_Id == id);
            if (transportModel == null)
            {
                return NotFound();
            }

            return View(transportModel);
        }

        // GET: TransportModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TransportModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Transport_Id,Pick_Up_Point,Delivery_point,Transport_Type")] TransportModel transportModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(transportModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(transportModel);
        }

        // GET: TransportModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Transports == null)
            {
                return NotFound();
            }

            var transportModel = await _context.Transports.FindAsync(id);
            if (transportModel == null)
            {
                return NotFound();
            }
            return View(transportModel);
        }

        // POST: TransportModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Transport_Id,Pick_Up_Point,Delivery_point,Transport_Type")] TransportModel transportModel)
        {
            if (id != transportModel.Transport_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transportModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransportModelExists(transportModel.Transport_Id))
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
            return View(transportModel);
        }

        // GET: TransportModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Transports == null)
            {
                return NotFound();
            }

            var transportModel = await _context.Transports
                .FirstOrDefaultAsync(m => m.Transport_Id == id);
            if (transportModel == null)
            {
                return NotFound();
            }

            return View(transportModel);
        }

        // POST: TransportModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Transports == null)
            {
                return Problem("Entity set 'AppDbContext.transports'  is null.");
            }
            var transportModel = await _context.Transports.FindAsync(id);
            if (transportModel != null)
            {
                _context.Transports.Remove(transportModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TransportModelExists(int id)
        {
          return (_context.Transports?.Any(e => e.Transport_Id == id)).GetValueOrDefault();
        }
    }
}
