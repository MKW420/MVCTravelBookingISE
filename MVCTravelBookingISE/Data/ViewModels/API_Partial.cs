using System;
using System.Collections.Generic;


namespace MVCTravelBookingISE.Data.ViewModels
{
    public partial class API_Partial
    {
        public int FlightId { get; set; }
        public bool? OneWay { get; set; }
        public string? DepartureDate { get; set; }
        public string? ReturnDate { get; set; }
        public string? StartLocation { get; set; }
        public string? EndLocation { get; set; }
        public string? Cost { get; set; }
        public int? ImageId { get; set; }

    }
}
