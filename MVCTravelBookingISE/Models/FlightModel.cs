using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCTravelBookingISE.Models
{
    public class FlightModel
    {
        [Key]
        public int ID { get; set; }
        public string Flight_Destination { get; set; }
        public string Flight_Departure { get; set; }
        public DateTime Flight_Date { get; set; }
        public char Flight_Class{ get; set; }

        [ForeignKey("FlightRules")]
        public int Flight_Rules_ID { get; set; }

      
    }
}
