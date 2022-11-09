using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCTravelBookingISE.Models
{
    public class FlightBookingItem
    {

        [Key]
        public int BookingId { get; set; }

        //Foreign key of Accomodation_ID
        public int Flight_Id { get; set; }
        [ForeignKey("Flight_Id")]
        public FlightModel Flight { get; set; }

        public string SessionId { get; set; }

        public List<TripManagementModel> Tripitem { get; set; }
    }
}
