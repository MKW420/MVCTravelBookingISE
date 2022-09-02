using System.ComponentModel.DataAnnotations;

namespace MVCTravelBookingISE.Models
{
    public class TransportModel
    {
        [Key]
        public int Transport_Id { get; set; }

        [Display(Name = "Pick up point")]

        [Required(ErrorMessage = "Pick point required")]
        public string Pick_Up_Point { get; set; }

        [Display(Name = "Destination point")]
        [Required(ErrorMessage = "Destination point Name required")]
        public string Destination_point { get; set; }

        [Display(Name = "Transport Type")]
        [Required(ErrorMessage = "Transport Type required")]
        public char Transport_Type { get; set; }

        [Display(Name = "Transport ratings")]
        public int Transport_ratings { get; set; }


        public virtual ICollection<BookingModel> Bookings { get; set; }
    }
}
