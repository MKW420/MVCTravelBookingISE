using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCTravelBookingISE.Models
{
    public class FlightModel
    {
        [Key]
        public int Flight_Id { get; set; }

        [Display(Name = "Flight Destination")]
        [Required(ErrorMessage = "Flight Destination required")]
        public string Flight_Destination { get; set; }


        [Display(Name = "Flight Departure")]
        [Required(ErrorMessage = "Flight Departure required")]
        public string Flight_Departure { get; set; }

        [Display(Name = "Flight Date and time")]
        [Required(ErrorMessage = "Date and time required")]
        public DateTime Flight_Date { get; set; }

        [Display(Name = "Flight Class")]
        [Required(ErrorMessage = "Flight class required")]
        public char Flight_Class{ get; set; }

        [Display(Name = "Flight price")]
        [Required(ErrorMessage = "Flight price required")]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Flight_Price{ get; set; }

        [ForeignKey("FlightRules_Id")]
        public int Flight_Rules_Id { get; set; }

        //Reltionships with other Models
        public virtual FlightRulesModel FlightRule { get; set; }
        public virtual ICollection<BookingModel> Bookings { get; set; }
    }
}
