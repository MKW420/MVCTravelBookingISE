using MessagePack;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MVCTravelBookingISE.Data.Base;

namespace MVCTravelBookingISE.Models
{
    public class Flights: IEntityBase
    {
        [System.ComponentModel.DataAnnotations.Key]

        public int Id { get; set; }
        public string Airline { get; set; }

        public string Flight_Destination { get; set; }
        public string Flight_Departure { get; set; }
        public DateTime Flight_Date { get; set; }
        public int seats { get; set; }
        public char Flight_Class { get; set; }

        [Display(Name = "Flight price")]
        [Required(ErrorMessage = "Flight price required")]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Flight_Price { get; set; }

        //[ForeignKey("FlightRules")]
        //public int Flight_Rules_ID { get; set; }


    }
}
