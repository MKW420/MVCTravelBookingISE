using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MVCTravelBookingISE.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCTravelBookingISE.Models
{
    public class Rating
    {
        [Key]
        public int Id { get; set; }

        public int rating { get; set; }

       public string UserId { get; set; }
 
        public int TripId { get; set; }
        [ForeignKey("TripId")]
        public TripManagementModel tripManagement { get; set; }
        public DateTime TimeStamp { get; set; }

        public string RatingComment { get; set; }
    }
}
