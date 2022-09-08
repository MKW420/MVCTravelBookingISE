using MVCTravelBookingISE.Models;

namespace MVCTravelBookingISE.Data.Services
{
    public interface IAccomodationService
    {
        Task<IEnumerable<AccomodationModel>> GetAllAsync();
        Task <AccomodationModel> GetByIdAsync(int id);

        Task AddAsync(AccomodationModel accomodationModel);
        AccomodationModel UpdateAsync (int id, AccomodationModel newAccomodation);
        void DeleteAsync(int id);
    
    }

   
}
