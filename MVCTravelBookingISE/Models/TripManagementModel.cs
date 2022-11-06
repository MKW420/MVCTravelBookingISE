using Microsoft.AspNetCore.Identity;
using MVCTravelBookingISE.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCTravelBookingISE.Models
{
    public class TripManagementModel
    {
        [Key]
       public int TripId { get; set; }

       public string UserId { get; set; }

        public int Acco_Id { get; set; }
        [ForeignKey("Acco_Id")]
        public AccomodationModel Accomodation { get; set; }

        public int Transport_Id { get; set; }
        [ForeignKey("Transport_Id")]
        public TransportModel transport { get; set; }

        public int Flight_Id { get; set; }
        [ForeignKey("Flight_Id")]
        public FlightModel flight { get; set; }

    }
}
