using MessagePack;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCTravelBookingISE.Models
{
    public class TravellerBooking
    {
        public string Traveller_Id { get; set; }

        public TravellerModel Traveller { get; set; }

        public int Booking_Id { get; set; }
        public BookingModel Booking { get; set; }

    }
}
