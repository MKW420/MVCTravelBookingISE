using MVCTravelBookingISE.Data.Reservations;
using MVCTravelBookingISE.Models;

namespace MVCTravelBookingISE.Data.Services
{
    public interface IBookingService
    {

        Task StoreBooking(List<BookingReserved> item, string userId, string userEmailAddress);
        Task<List<BookingModel>> GetBookingByUserId(string userId);
    }
}
