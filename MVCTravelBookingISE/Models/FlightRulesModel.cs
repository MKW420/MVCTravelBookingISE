﻿using System.ComponentModel.DataAnnotations;

namespace MVCTravelBookingISE.Models
{
    public class FlightRulesModel
    {
        [Key]
        public int FlightRules_Id { get; set; }

        [Required(ErrorMessage = "Flight Description required")]
        public string Flight_Descrip { get; set; }

        [Required(ErrorMessage = "Flight Name required")]
        public string Flight_Name { get; set; }

    }
}