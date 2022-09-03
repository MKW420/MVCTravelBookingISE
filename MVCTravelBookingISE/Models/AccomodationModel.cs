using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCTravelBookingISE.Models
{
    public class AccomodationModel
    {
        [Key]
        public int Acco_Id { get; set; }

        [Display(Name = "Name of the accomodation")]
        [Required(ErrorMessage = "Accomodation Name required")]
        public string Acco_Name { get; set; }

        [Display(Name = "Name of accomodation destination")]
        [Required(ErrorMessage = "Destination required")]
        public string Acco_Destination { get; set; }

        [Display(Name = "Number of rooms ")]
        [Required(ErrorMessage = "Number of rooms required")]
        public int Acco_Rooms { get; set; }


        [Display(Name = "Number of bathrooms ")]
        [Required(ErrorMessage = "Number of bathrooms  required")]
        public int Acco_Bathrooms { get; set; }

        [Display(Name = "Raduis  of the distance from airport")]
        [Required(ErrorMessage = "Distance from airport required")]
        [Column(TypeName ="decimal(10,2")]
        public decimal Acco_Distance { get; set; }

        [Display(Name = "Ratings of the Accomodation")]
        public int Acco_Rate { get; set; }

        [Display(Name = "Type of accomodation")]
        [Required(ErrorMessage = "Type of accomodation required")]
        public char Acco_Type { get; set; }

        [Display(Name = "Price of accomodoation")]
        [Required(ErrorMessage = "Price of Accomodation required")]
        [Column(TypeName = "decimal(10,2")]
        public decimal Acco_Price { get; set; }


        public virtual ICollection<BookingModel> Bookings { get; set; }
        


    }
}
