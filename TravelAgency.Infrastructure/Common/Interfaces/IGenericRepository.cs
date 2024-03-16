using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelAgency.Domain.Common;

namespace TravelAgency.Infrastructure.Common.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity:BaseEntity
    {
        Task CreateAsync(TEntity element, CancellationToken cancellationToken = default);
        Task UpdateAsync(TEntity element, CancellationToken cancellationToken = default);
        Task DeleteAsync(TEntity element, CancellationToken cancellationToken = default);
        Task<TEntity> GetByIdAsync<TId>(TId elementId, CancellationToken cancellationToken = default);
        Task<IEnumerable<TEntity>> ListAgencyAsync(CancellationToken cancellationToken = default);
        Task DeleteByIdAsync(int elementId, CancellationToken cancellationToken = default);
        
    }
}