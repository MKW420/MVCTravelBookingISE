using System.ComponentModel.DataAnnotations;

namespace MVCTravelBookingISE.Models
{
    public class FlightRulesModel
    {
        [Key]
        public int FlightRules_Id { get; set; }
        public string Flight_Descrip { get; set; }
        public string Flight_Name { get; set; }

    }
}
