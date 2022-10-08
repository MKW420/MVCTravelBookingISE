using System.ComponentModel.DataAnnotations;

namespace MVCTravelBookingISE.Models
{
    public class ReservedItem
    {
        [Key]
        public int Id { get; set; }
        
        public AccomodationModel Accomodation { get; set; }
        public int Qauntity { get; set; } 
        public int ReservedBooking_Id { get; set; }


    }
}
