using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCTravelBookingISE.Models
{
    public class FlightModel
    {
        [Key]
        public int Flight_Id { get; set; }
        public string Flight_Destination { get; set; }
        public string Flight_Departure { get; set; }
        public DateTime Flight_Date { get; set; }
        public char Flight_Class{ get; set; }

        [ForeignKey("FlightRules_Id")]
        public int Flight_Rules_Id { get; set; }

        //Reltionships with other Models
        public List<FlightRulesModel> FlightRules { get; set; }


    }
}
