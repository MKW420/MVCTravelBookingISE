using MessagePack;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCTravelBookingISE.Models
{
    public class TravellerBooking
    {
        public int Traveller_Id { get; set; }

        public TravellerModel Travellers { get; set; }

        public int Booking_Id { get; set; }
        public BookingModel Bookings { get; set; }

    }
}
