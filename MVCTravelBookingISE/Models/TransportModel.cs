using MVCTravelBookingISE.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace MVCTravelBookingISE.Models
{
    public class TransportModel: IEntityBase { 

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

        [Display(Name = "Average ratings")]
        public int Transport_ratings { get; set; }
        public string Transport_Status { get; set; }
       
        public List<TransportBookingItem> Bookingitem { get; set; }

        public bool Transport_FuelCard { get; set; }

        public decimal Transport_Price { get; set; }

    }
}
