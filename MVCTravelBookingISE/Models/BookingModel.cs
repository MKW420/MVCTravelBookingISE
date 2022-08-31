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

        [Required(ErrorMessage = "Booking Date required")]
        public DateTime Booking_date{ get; set; }

        [ForeignKey("Flight_Id")]
        public string Flight_Id { get; set; }

        [ForeignKey("Acco_Id")]
        public string Acco_Id { get; set; }

        [ForeignKey("Traveller_Id")]
        public  int Traveller_Id { get; set; }

       //Reltionships
       
        public List<FlightModel> Flights { get; set; }
        public List<AccomodationModel> Accomodations { get; set; }
        public List<TravellerModel> Travellers { get; set; }

        public virtual ICollection<TravellerBooking> TravellerBookings { get; set; }
       
        
    }
}
