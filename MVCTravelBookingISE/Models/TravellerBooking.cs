using MessagePack;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCTravelBookingISE.Models
{
    public class TravellerBooking
    {

        public int Traveller_Id { get; set; }
        [ForeignKey("Traveller_Id")]
        public TravellerModel Traveller { get; set; }

        public int Booking_Id { get; set; }
        [ForeignKey("Booking_Id")]
        public BookingModel Booking { get; set; }

        public string Booking_approved { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Total_price { get; set; }
        

    }
}
