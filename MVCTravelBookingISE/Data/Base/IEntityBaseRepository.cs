using MVCTravelBookingISE.Models;

namespace MVCTravelBookingISE.Data.Base
{
    public class IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);

      
        Task Add(T actor);
        Task Update(int id, AccomodationModel newAccomodation);
        void Delete(int id);

    }
}
