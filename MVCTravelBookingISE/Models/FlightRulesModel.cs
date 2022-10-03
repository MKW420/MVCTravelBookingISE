using System.ComponentModel.DataAnnotations;

namespace MVCTravelBookingISE.Models
{
    public class FlightRulesModel
    {
        [Key]
        public int FlightRules_Id { get; set; }

        [Display(Name = "Flight Description")]
        [Required(ErrorMessage = "Flight Description required")]
        public string Flight_Descrip { get; set; }

        [Display(Name = "Flight Name")]
        [Required(ErrorMessage = "Flight Name required")]
        public string Flight_Name { get; set; }

        //Reltionships with other models
        public List<FlightModel> Flights { get; set; }
       
    }
}
