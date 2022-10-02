using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NuGet.Protocol.Core.Types;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCTravelBookingISE.Models
{
    public class BookingModel
    {
        [Key]
        public int Booking_Id { get; set; }

        [Display(Name = "Name of the booking")]
        [Required(ErrorMessage = "Booking Name required")]
        public string Booking_Name { get; set; }

        [Display(Name = "The date of the booking ")]
        [Required(ErrorMessage = "Booking Date required")]
        public DateTime Booking_date{ get; set; }

        [Display(Name = "Approved Y/N")]
        public string Booking_Approved { get; set; }

        [Display(Name = "Total price of the booking")]
        public decimal Booking_TotalPrice { get; set; }

     
       //Reltionships with other models 
       public List<TravellerBooking> TravellerBookings { get; set; }

        //foreign key of Flight_ID

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
