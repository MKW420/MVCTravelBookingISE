using Microsoft.EntityFrameworkCore;
using MVCTravelBookingISE.Data.Reservations;
using MVCTravelBookingISE.Models;

namespace MVCTravelBookingISE.Data.Services
{
    public class BookingService : IBookingService
    {

        private readonly AppDbContext _context;

        public BookingService(AppDbContext context)
        {
            _context = context;
        }

        public Task<List<BookingModel>> GetBookingByUserId(string userId)
        {
          var booking = _context.Booking.Include(n => n.BookingAccoItem).ThenInclude(n => n.Accomodation).Where(n => n.UserId == userId).ToListAsync();
            return booking;
        }

        public async Task StoreBooking(List<BookingReserved> items, string userId, string userEmailAddress)
        {
            var booking = new BookingModel()
            {
                UserId = userId,
                Email = userEmailAddress
            };

            await _context.Booking.AddAsync(booking);
            await _context.SaveChangesAsync();

            foreach(var item in items)
            {
            }
        }
    }
}
