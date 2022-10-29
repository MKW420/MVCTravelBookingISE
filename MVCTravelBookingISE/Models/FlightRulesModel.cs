using MVCTravelBookingISE.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace MVCTravelBookingISE.Models
{
    public class FlightRulesModel:IEntityBase
    {
        [Key]
        public int FlightRules_Id { get; set; }

        [Display(Name = "Airline Rule")]
        [Required(ErrorMessage = "Flight Description required")]
        public string Flight_Descrip { get; set; }

        [Display(Name = "Airlines")]
        [Required(ErrorMessage = "Flight Name required")]
        public string Flight_Name { get; set; }

        //Reltionships with other models
        public List<FlightModel> Flights { get; set; }
       
    }
}
