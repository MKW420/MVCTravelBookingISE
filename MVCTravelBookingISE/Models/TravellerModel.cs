using System.ComponentModel.DataAnnotations;

namespace MVCTravelBookingISE.Models
{
    public class TravellerModel
    {
        [Key]
        public int Traveller_Id { get; set; }

        [Required(ErrorMessage = "First Name required")]
        public string First_Name { get; set; }

        [Required(ErrorMessage = "Last Name required")]
        public string Last_Name { get; set; }

        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invaild email address")]
        public string Email { get; set; }

        public DateTime Date_Of_Birth { get; set; }

        public int Ratings { get; set; }

        public virtual ICollection<TravellerBooking> TravellerBookings { get; set; }

    }
}
