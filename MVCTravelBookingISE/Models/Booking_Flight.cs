namespace MVCTravelBookingISE.Models
{
    public class Booking_Flight
    {
        public int TravellerId { get; set; }

        public BookingModel Booking { get; set; }

        public int FlightId { get; set; }
        public FlightModel Flight { get; set; }
        public object BookingId { get; set; }
    }
}
