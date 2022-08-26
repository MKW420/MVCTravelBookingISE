using System.ComponentModel.DataAnnotations;

namespace MVCTravelBookingISE.Models
{
    public class TravellerModel
    {
        [Key]
        public int Traveller_Id { get; set; }

        public string First_Name { get; set; }
        
        public  string  Last_Name { get; set; }

        public string Email { get; set; }

        public DateTime Date_Of_Birth { get; set; }

        public int Ratings { get; set; }
    }
}
