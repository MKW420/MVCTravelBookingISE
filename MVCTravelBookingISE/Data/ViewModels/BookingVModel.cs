using MVCTravelBookingISE.Data.Reservations;
using MVCTravelBookingISE.Models;

namespace MVCTravelBookingISE.Data.ViewModels
{
    public class BookingVModel
    {

        public BookingReserved bookingReserved {get; set; }

        public decimal BookingTotalPrice { get; set; }

    }
}
