using System.ComponentModel.DataAnnotations;

namespace MVCTravelBookingISE.Models
{
    public class TransportModel
    {
        [Key]
        public int Transport_Id { get; set; }
        public string Pick_Up_Point { get; set; }
        public string Delivery_point { get; set; }
        public char Transport_Type { get; set; }

    }
}
