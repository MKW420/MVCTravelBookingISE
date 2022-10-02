using System.ComponentModel.DataAnnotations;

namespace MVCTravelBookingISE.Models
{
    public class Rating
    {
        [Key]
        public int RatingsId { get; set; }

        public int rating { get; set; }

        public int UserID { get; set; }

        public int item_ID { get; set; }
        public DateTime TimeStamp { get; set; }

        public string RatingComment { get; set; }
    }
}
