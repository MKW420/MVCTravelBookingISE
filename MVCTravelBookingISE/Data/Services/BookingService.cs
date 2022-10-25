using Microsoft.EntityFrameworkCore;
using MVCTravelBookingISE.Data.Reservations;
using MVCTravelBookingISE.Models;

namespace MVCTravelBookingISE.Data.Services
{
    public class BookingService : IBookingService
    {


        private readonly AppDbContext _context;

        public BookingService(AppDbContext context) { 
        }
        public Task<List<BookingModel>> GetBookingByUserIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task StoreBookingAsync(List<BookingAccoItem> bookingAccoItems, string userId, string emailAddress)
        {
            throw new NotImplementedException();
        }
    }
}
