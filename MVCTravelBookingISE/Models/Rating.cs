using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCTravelBookingISE.Models
{
    public class Rating
    {
        [Key]
        public int RatingsId { get; set; }

        public int rating { get; set; }

        public string UserId { get; set; }

        public int Booking_Id { get; set; }
        [ForeignKey("Booking_Id")]
        public BookingModel Booking { get; set; }
        public DateTime TimeStamp { get; set; }

        public string RatingComment { get; set; }
    }
}
