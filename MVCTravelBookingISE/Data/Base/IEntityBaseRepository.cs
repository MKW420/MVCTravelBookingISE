﻿using MVCTravelBookingISE.Models;
using System.Linq.Expressions;

namespace MVCTravelBookingISE.Data.Base
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties);
        Task<T> GetByIdAsync(int id);
        Task<T> GetByIdAsync(int id, params Expression<Func<T, object>>[] includeProperties);
        Task AddSync(T entity);
        Task UpdateAsync(int id, T entity);
        Task DeleteAsync(int id);

  
    }
}
