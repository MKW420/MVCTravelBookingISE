using System.ComponentModel.DataAnnotations;

namespace MVCTravelBookingISE.Models
{
    public class TransportModel
    {
        [Key]
        public int Transport_Id { get; set; }

        [Required(ErrorMessage = "Pick point required")]
        public string Pick_Up_Point { get; set; }

        [Required(ErrorMessage = "Destination point Name required")]
        public string Destination_point { get; set; }

        [Required(ErrorMessage = "Transport Type required")]
        public char Transport_Type { get; set; }
        public int Transport_ratings { get; set; }


    }
}
