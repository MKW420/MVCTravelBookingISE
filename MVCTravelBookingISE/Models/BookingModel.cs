using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCTravelBookingISE.Models
{
    public class BookingModel
    {
        [Key]
        public int Booking_ID { get; set; }
        public string Booking_Name { get; set; }

        public DateTime Booking_date{ get; set; }

        [ForeignKey("Booking")]
        public string Flight_ID { get; set; }

        [ForeignKey("Accodomation")]
        public string Acco_ID { get; set; }

        [ForeignKey("Traveller")]
        public  int Traveller_ID { get; set; }

   



    }
}
