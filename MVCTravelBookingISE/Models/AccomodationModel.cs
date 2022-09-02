using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCTravelBookingISE.Models
{
    public class AccomodationModel
    {
        [Key]
        public int Acco_Id { get; set; }

        [Required(ErrorMessage = "Accomodation Name required")]
        public string Acco_Name { get; set; }

        [Required(ErrorMessage = "Destination required")]
        public string Acco_Destination { get; set; }

        [Required(ErrorMessage = "Number of rooms required")]
        public int Acco_Rooms { get; set; }

        [Required(ErrorMessage = "Number of bathrooms  required")]
        public int Acco_Bathrooms { get; set; }

        [Required(ErrorMessage = "Distance from airport required")]
        [Column(TypeName ="decimal(10,2)")]
        public decimal Acco_Distance { get; set; }
       
        public int Acco_Rate { get; set; }

        [Required(ErrorMessage = "Type of accomodation required")]
        public char Acco_Type { get; set; }

        [Required(ErrorMessage = "Price of Accomodation required")]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Acco_Price { get; set; }

        




    }
}
