using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCTravelBookingISE.Models
{
    public class RewardsModel
    {
        [Key]
        public int Rewards_Id { get; set; }

        [Required(ErrorMessage ="Rewards Name")]
        public string Rewards_Name { get; set; }

        public string Rewards_Description { get; set; }

        public string Rewards_Status { get; set; }

        [Display(Name = "Rewards Expiry Date Name")]
        [Required(ErrorMessage = "Expiry Date required")]
        public DateTime ExpiryRewardsDate { get; set; }

        public int Traveller_Id { get; set; }
        [ForeignKey("Traveller_Id")]
        public TravellerModel Traveller { get; set; }



    }
}
