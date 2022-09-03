using MessagePack;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace MVCTravelBookingISE.Models
{
    public class TravellerBooking
    {
        
        public int Traveller_Id { get; set; }
        public TravellerModel traveller { get; set; }
        public int Booking_Id { get; set; }
        public BookingModel booking { get; set; }


        //RELTIONSHIPS WITH OTHER MODELS

        public virtual BookingModel Booking { get; set; }
        public virtual TravellerModel Traveller { get; set; }
       

    }
}
