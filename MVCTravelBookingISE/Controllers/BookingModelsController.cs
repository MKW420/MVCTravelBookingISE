using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
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

        int count = 0;
        public int Booking_Id { get; set; }

        public List<AccomodationModel> Accomodations { get; set; }

        public List<FlightModel> FlightModels { get; set; }

        public BookingModelsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: BookingModels
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            return _context.Booking != null ?
                        View(await _context.Booking.ToListAsync()) :
                        Problem("Entity set 'AppDbContext.Bookings'  is null.");
        }

        // GET: BookingModels/Details/5
        [AllowAnonymous]
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
        [Authorize]
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

        [Authorize]
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
        [Authorize]
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
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
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

        // POST: BookingModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
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

        public decimal GetBookingTotal() => _context.Booking.Select(n => n.Accomodation.Acco_Price + n.Flight.Flight_Price).Sum();


    

        public void AddAccoItemToBooking(AccomodationModel accomodation, int id)
        {
            int count = 0;
            var item = _context.Accomodation.FirstOrDefault(n => n.Acco_Id == accomodation.Acco_Id);
         //   var itemexist = await _context.Accomodation?.Any(e => e.Acco_Id ==  id)).

            //if accomodation is not on the booking  add new 

            //if(accomodation == null) { 


            //    accomodation = new AccomodationModel()
            //    {
            //         count = 1
            //    };

            //}


            _context.Accomodation.Add(item);
            count++;
            _context.SaveChanges();
        }

    
        public  void AddFlightItemToBooking(FlightModel flight, int id)
        {
           
            int count = 0;
            var existitem = _context.Flight?.Any(n => n.Flight_Id == flight.Flight_Id);
            var item = _context.Flight.FirstOrDefault(n => n.Flight_Id == flight.Flight_Id);
          

            //if accomodation is not on the booking  add new 

            if (existitem == null)
            {

                _context.Flight.Add(item);
                count++;


            }


            
           
            _context.SaveChanges();
        }
        public void RemoveItemFlightFromBooking(FlightModel flight)
        {
            int count = 0;
            var item = _context.Flight.FirstOrDefault(n => n.Flight_Id == flight.Flight_Id);

            if(item != null)
            {
                if(count > 1)
                {
                    count--;

                }
                else
                {
                    _context.Flight.Remove(item);

                }

            }
            _context.SaveChanges();
        }
    }

    
 }

