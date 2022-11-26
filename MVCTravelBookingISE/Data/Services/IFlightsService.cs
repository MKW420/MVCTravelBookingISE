using MVCTravelBookingISE.Data.Base;
using MVCTravelBookingISE.Models;

namespace MVCTravelBookingISE.Data.Services
{
    public interface IFlightsService : IEntityBaseRepository<Flights>
    {
           Task<Flights> GetFlightsByIdAsync(int id);
           Task UpdateFlightAsync(Flights data);
    
    }
}
