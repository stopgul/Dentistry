using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Dentistry.EntityFramework.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<int> AddAsync(TEntity obj);
        Task<IEnumerable<TEntity>> GetByConditionAsync(Expression<Func<TEntity, bool>> expression);
        Task<TEntity> GetByIdAsync(long id);
        Task<int> RemoveAsync(long id);
        Task<int> UpdateAsync(TEntity obj);
    }
}
