using MVCTravelBookingISE.Models;

namespace MVCTravelBookingISE.Data.Services
{
    public interface IAccomodationService
    {
        Task<IEnumerable<AccomodationModel>> GetAllAsync();
        Task <AccomodationModel> GetByIdAsync(int id);

        Task AddAsync(AccomodationModel accomodationModel);
        Task <AccomodationModel> UpdateAsync (int id, AccomodationModel newAccomodation);
        Task DeleteAsync(int id);


    
    }

   
}
