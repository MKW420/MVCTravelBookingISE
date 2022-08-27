using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCTravelBookingISE.Models
{
    public class FlightModel
    {
        [Key]
        public int Flight_Id { get; set; }

        [Required(ErrorMessage = "Flight Destination required")]
        public string Flight_Destination { get; set; }

        [Required(ErrorMessage = "Flight Departure required")]
        public string Flight_Departure { get; set; }

        [Required(ErrorMessage = "Date and time required")]
        public DateTime Flight_Date { get; set; }

        [Required(ErrorMessage = "Flight class required")]
        public char Flight_Class{ get; set; }

        [Required(ErrorMessage = "Flight price required")]
        [Column(TypeName = "decimal(10,2")]
        public decimal Flight_Price{ get; set; }

        [ForeignKey("FlightRules_Id")]
        public int Flight_Rules_Id { get; set; }

        //Reltionships with other Models
        public List<FlightRulesModel> FlightRules { get; set; }


    }
}
