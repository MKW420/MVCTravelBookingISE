using MVCTravelBookingISE.Data.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCTravelBookingISE.Models
{
    public class RewardsModel:IEntityBase
    {
        [Key]
        public int Rewards_Id { get; set; }

        public string UserId { get; set; }


        [Required(ErrorMessage ="Rewards Name")]
        public string Rewards_Name { get; set; }

        public string Rewards_Description { get; set; }

        public string Rewards_Status { get; set; }

        [Display(Name = "Rewards Expiry Date Name")]
        [Required(ErrorMessage = "Expiry Date required")]
        public DateTime ExpiryRewardsDate { get; set; }

    

    }
}
