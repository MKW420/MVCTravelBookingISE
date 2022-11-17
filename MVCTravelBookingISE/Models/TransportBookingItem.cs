using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCTravelBookingISE.Models
{
    public class TransportBookingItem
    {


            [Key]
            public int BookingId { get; set; }

            //Foreign key of Transport_ID
            public int Transport_Id { get; set; }
            [ForeignKey("Transport_Id")]
            public TransportModel transport { get; set; }

            public string SessionId { get; set; }

            public List<TripManagementModel> Tripitem { get; set; }
        
    }
}
