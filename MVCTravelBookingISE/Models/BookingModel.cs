using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MVCTravelBookingISE.Areas.Identity.Data;
using NuGet.Protocol.Core.Types;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCTravelBookingISE.Models
{
    public class BookingModel
    {
        [Key]
        public int Booking_Id { get; set; }

        public string Email { get; set; }

        public string UserId { get; set; }
        //[ForeignKey(nameof(UserId))]
        //public ApplicationUser User { get; set; }



        [Display(Name = "The date of the booking ")]
        [Required(ErrorMessage = "Booking Date required")]
        public DateTime Booking_Startdate { get; set; }

        public DateTime Booking_Enddate { get; set; }

        [Display(Name = "Approved Yes/No")]
        public string Booking_Approved { get; set; }


        public List<Rating> Ratings { get; set; }



        public int Item_Id { get; set; }
        [ForeignKey("Item_Id")]
        public BookingAccoItem BookingAccoItem { get; set; }






    }
}
