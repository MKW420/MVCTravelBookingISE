using MessagePack;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace MVCTravelBookingISE.Models
{
    public class TravellerBooking
    {
        
        public int Traveller_Id { get; set; }
        public TravellerModel Traveller { get; set; }
        public int Booking_Id { get; set; }
        public BookingModel Booking { get; set; }

      
       

    }
}
