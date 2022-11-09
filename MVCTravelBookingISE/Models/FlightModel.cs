using MVCTravelBookingISE.Data.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCTravelBookingISE.Models
{
    public class FlightModel:IEntityBase
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
        public DateTime FromDate { get; set; }


        [Display(Name = "Flight Date and time")]
        [Required(ErrorMessage = "Date and time required")]
        public DateTime ToDate { get; set; }

        [Display(Name = "Flight Class")]
        [Required(ErrorMessage = "Flight class required")]
        public char Flight_Class{ get; set; }

        [Display(Name = "Flight price")]
        [Required(ErrorMessage = "Flight price required")]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Flight_Price{ get; set; }

        
        public int FlightRules_Id { get; set; }
        [ForeignKey("FlightRules_Id")]
        public FlightRulesModel FlightRule { get; set; }
        //Reltionships with other Models

        public List<TripManagementModel> TripManagements { get; set; }
        public List<FlightBookingItem> Bookingitem { get; set; }

    }
}
