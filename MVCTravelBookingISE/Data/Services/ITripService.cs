using MVCTravelBookingISE.Data.Base;
using MVCTravelBookingISE.Data.ViewModels;
using MVCTravelBookingISE.Models;

namespace MVCTravelBookingISE.Data.Services
{
    public interface ITripService: IEntityBaseRepository<TripManagementModel>
    {


        Task<TripManagementModel> GetTripByIdAsync(int id);

        Task AddNewTripAsync(TripVM data);
    
    }
}
