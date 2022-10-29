using MVCTravelBookingISE.Data.Base;
using MVCTravelBookingISE.Models;

namespace MVCTravelBookingISE.Data.Services
{
    public interface IFlightRulesService : IEntityBaseRepository <FlightRulesModel>
    {

        Task<FlightRulesModel> GetFlightRulesByIdAsync(int id);

        // Task<Accomodation> AddNewAccomodationAsync(NewAccomdation data);
        Task AddNewFlightRule(FlightRulesModel data);
        Task UpdateFlightAsync(FlightRulesModel data);

    }
}
