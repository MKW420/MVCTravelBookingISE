using System.ComponentModel.DataAnnotations;

namespace MVCTravelBookingISE.Models
{
    public class ReservedItem
    {
        [Key]
        public int Id { get; set; }
        
        public AccomodationModel Accomodation { get; set; }

        public BookingModel Booking { get; set; }

        public  FlightModel Flight { get; set; }    

        public int Amount { get; set; } 

        public int ReservedBooking_Id { get; set; }


    }
}
