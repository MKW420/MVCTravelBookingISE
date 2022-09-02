using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCTravelBookingISE.Models
{
    public class BookingModel
    {
        [Key]
        public int Booking_Id { get; set; }

        [Display(Name = "Name of the booking")]
        [Required(ErrorMessage = "Booking Name required")]
        public string Booking_Name { get; set; }

        [Display(Name = "The date of the booking ")]
        [Required(ErrorMessage = "Booking Date required")]
        public DateTime Booking_date{ get; set; }

        //foreign key of Flight_ID
        
        public string Flight_Id { get; set; }
        public FlightModel flight { get; set; }

        //Foreign key of Accomodation_ID
        public string Acco_Id { get; set; }
        public AccomodationModel accomodation { get; set; }
  
        //foreign key of transport
        public  int Transport_Id { get; set; }
        public TransportModel transport { get; set; }   
     
        //Reltionships with other models 
        public virtual AccomodationModel Accomodation { get; set; }
        public virtual FlightModel Flight { get; set; }
        public virtual TransportModel Transport { get; set; }
        public virtual ICollection<TravellerBooking> TravellerBookings { get; set; }


    }
}
