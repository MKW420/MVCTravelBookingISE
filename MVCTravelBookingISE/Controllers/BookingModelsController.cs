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
    public class BookingModelsController : Controller
    {
        private readonly AppDbContext _context;

        public BookingModelsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: BookingModels
        public async Task<IActionResult> Index()
        {
              return _context.Booking != null ? 
                          View(await _context.Booking.ToListAsync()) :
                          Problem("Entity set 'AppDbContext.Bookings'  is null.");
        }

        // GET: BookingModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Booking == null)
            {
                return NotFound();
            }

            var bookingModel = await _context.Booking
                .FirstOrDefaultAsync(m => m.Booking_Id == id);
            if (bookingModel == null)
            {
                return NotFound();
            }

            return View(bookingModel);
        }

        // GET: BookingModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BookingModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Booking_Id,Booking_Name,Booking_date,Flight_Id,Acco_Id,Traveller_Id")] BookingModel bookingModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bookingModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bookingModel);
        }

        // GET: BookingModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Booking == null)
            {
                return NotFound();
            }

            var bookingModel = await _context.Booking.FindAsync(id);
            if (bookingModel == null)
            {
                return NotFound();
            }
            return View(bookingModel);
        }

        // POST: BookingModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Booking_Id,Booking_Name,Booking_date,Flight_Id,Acco_Id,Traveller_Id")] BookingModel bookingModel)
        {
            if (id != bookingModel.Booking_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bookingModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookingModelExists(bookingModel.Booking_Id))
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
            return View(bookingModel);
        }

        // GET: BookingModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Booking== null)
            {
                return NotFound();
            }

            var bookingModel = await _context.Booking
                .FirstOrDefaultAsync(m => m.Booking_Id == id);
            if (bookingModel == null)
            {
                return NotFound();
            }

            return View(bookingModel);
        }

        // POST: BookingModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Booking == null)
            {
                return Problem("Entity set 'AppDbContext.Bookings'  is null.");
            }
            var bookingModel = await _context.Booking.FindAsync(id);
            if (bookingModel != null)
            {
                _context.Booking.Remove(bookingModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookingModelExists(int id)
        {
          return (_context.Booking?.Any(e => e.Booking_Id == id)).GetValueOrDefault();
        }
    }
}
