using Microsoft.AspNetCore.Identity;
using MVCTravelBookingISE.Areas.Identity.Data;
using MVCTravelBookingISE.Data.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCTravelBookingISE.Models
{
    public class TripManagementModel:IEntityBase
    {
        [Key]
       public int TripId { get; set; }

       public string UserId { get; set; }


     
        public int BookingAccoId { get; set; }
        [ForeignKey("BookingAccoId")]
        public BookingAccoItem bookedAccoItem { get; set; }

       

    }
}
