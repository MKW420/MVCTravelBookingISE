using MVCTravelBookingISE.Models;

namespace MVCTravelBookingISE.Data.Base
{
    public class IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);

      
        Task AddSync(T actor);
        Task <T> UpdateAsync(int id, T entity);
        Task DeleteAsync(int id);

    }
}
