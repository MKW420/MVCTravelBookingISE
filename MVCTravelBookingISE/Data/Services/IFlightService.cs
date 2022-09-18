using MVCTravelBookingISE.Models;

namespace MVCTravelBookingISE.Data.Services
{
    public interface IFlightService
    {
        IEnumerable<FlightModel> GetAll();
        FlightModel GetById(int id);

        void Add(FlightModel FlightModel);
        FlightModel Update(int id, FlightModel newFlight);
        void Delete(int id);


    }
}
