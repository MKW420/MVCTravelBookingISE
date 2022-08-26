using System.ComponentModel.DataAnnotations;

namespace MVCTravelBookingISE.Models
{
    public class FlightRulesModel
    {
        [Key]
        public int Flight_RulesId { get; set; }
        public string Flight_Descrip { get; set; }
        public string Flight_Name { get; set; }

    }
}
