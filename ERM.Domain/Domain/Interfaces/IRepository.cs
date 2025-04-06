using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERM.Domain.Domain.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
       Task<TEntity> GetByIdAsync(int Id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> AddAsync(TEntity entity);
        Task<TEntity> UpdateAsync(
            TEntity entity);
        Task DeleteAsync(int Id);
    }
}
