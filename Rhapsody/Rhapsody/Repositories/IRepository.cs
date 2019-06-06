using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Rhapsody.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<IQueryable<TEntity>> GetAsync(
            Expression<Func<TEntity, bool>> predicate = null, 
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = ""
            );
        
        Task<TEntity> GetAsync(object id);

        Task InsertAsync(TEntity obj);

        Task UpdateAsync(TEntity obj);

        Task DeleteAsync(object id);

         Task DeleteAsync(TEntity obj);
    }
}
