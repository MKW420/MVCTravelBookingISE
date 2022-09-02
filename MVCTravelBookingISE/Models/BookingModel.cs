using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCTravelBookingISE.Models
{
    public class BookingModel
    {
        [Key]
        public int Booking_Id { get; set; }

        [Display(Name ="The name of the Booking")]
        [Required(ErrorMessage = "Booking Name required")]
        public string Booking_Name { get; set; }

        [Display(Name = "The date of the booking")]
        [Required(ErrorMessage = "Booking Date required")]
        public DateTime Booking_date{ get; set; }

        //flight
        public int Flight_Id { get; set; }
        [ForeignKey("Flight_Id")]
        public  FlightModel Flight { get; set; }

        //accomodation
        public int Acco_Id { get; set; }
        [ForeignKey("Acco_Id")]
        public AccomodationModel Accomodation { get; set; }

        //travellers
        public  int Traveller_Id { get; set; }
        [ForeignKey("Traveller_Id")]
        public TravellerModel Traveller { get; set; }   


        

       //Reltionships : joining table

       public List<TravellerBooking> travellerBookings { get; set; }
       

    
       
        
    }
}
