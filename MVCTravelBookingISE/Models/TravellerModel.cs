using System.ComponentModel.DataAnnotations;

namespace MVCTravelBookingISE.Models
{
    public class TravellerModel
    {
        [Key]
        public int Traveller_Id { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name required")]
        public string First_Name { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name required")]
        public string Last_Name { get; set; }

        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invaild email address")]
        public string Email { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime Date_Of_Birth { get; set; }

        [Display(Name = "Travellers Ratings")]
        public int Ratings { get; set; }

        //reltionship with other table
        public List<TravellerBooking> TravellerBookings { get; set; }

    
    }
}
