using MVCTravelBookingISE.Data.Base;
using MVCTravelBookingISE.Data.Reservations;
using MVCTravelBookingISE.Models;

namespace MVCTravelBookingISE.Data.Services
{
    public interface IBookingService
    {
        Task StoreBookingAsync(List<BookingAccoItem> bookingAccoItems, string userId, string emailAddress);
        Task<List<BookingModel>> GetBookingByUserIdAsync(string userId);

    }
}
