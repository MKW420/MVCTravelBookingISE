using MVCTravelBookingISE.Data.Base;
using MVCTravelBookingISE.Models;

namespace MVCTravelBookingISE.Data.Services
{
    public class FlightService :EntityBaseRepository<FlightModel>,IFlightService
    {


       // private readonly AppDbContext _context;

        public FlightService(AppDbContext context) : base(context) { }
    }
}
