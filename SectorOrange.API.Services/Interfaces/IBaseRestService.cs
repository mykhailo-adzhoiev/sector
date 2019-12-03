using SectorOrange.API.Services.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SectorOrange.API.Services.Interfaces
{
    public interface IBaseRestService<T, TId> where T : IBaseEntity<TId>
    {
        Task AddAsync(T model);
        Task DeleteAsync(TId id);
        Task UpdateAsync(T model);
        Task<List<T>> GetAllAsync();
        Task<T> GetAsync(TId id);
    }
}
