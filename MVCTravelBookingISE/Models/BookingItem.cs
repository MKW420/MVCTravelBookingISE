using MessagePack;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MVCTravelBookingISE.Data.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCTravelBookingISE.Models
{
    public class BookingItem
    {

        [System.ComponentModel.DataAnnotations.Key]
        public int Item_Id { get; set; }
        public int Amount { get; set; }

        [Display(Name = "Total price of the booking")]
        public decimal Price { get; set; }
        public int Booking_Id { get; set; }
        [ForeignKey("Booking_Id")]
        public BookingModel Booking { get; set; }   
        public int Flight_Id { get; set; }
        [ForeignKey("Flight_Id")]
        public FlightModel Flight { get; set; }

        //Foreign key of Accomodation_ID
        public int Acco_Id { get; set; }
        [ForeignKey("Acco_Id")]
        public AccomodationModel Accomodation { get; set; }

        //foreign key of transport
        public int Transport_Id { get; set; }
        [ForeignKey("Transport_Id")]
        public TransportModel Transport { get; set; }

       

    }
   
}
