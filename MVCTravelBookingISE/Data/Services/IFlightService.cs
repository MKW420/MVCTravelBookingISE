using MVCTravelBookingISE.Data.Base;
using MVCTravelBookingISE.Models;

namespace MVCTravelBookingISE.Data.Services
{
    public interface IFlightService : IEntityBaseRepository<FlightModel>
    {

        Task<FlightModel> GetFlightsByIdAsync(int id);
        Task UpdateFlightAsync(FlightModel data);
    }
}
