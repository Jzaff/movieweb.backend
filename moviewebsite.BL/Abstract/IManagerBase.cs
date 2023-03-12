using moviewebsite.Entities.Abstract;
using System.Linq.Expressions;

namespace moviewebsite.BL.Abstract
{
    public interface IManagerBase<T> where T : BaseEntity, new()
    {
        Task<int> AddAsync(T input);
        Task<int> UpdateAsync(T input);
        Task<int> DeleteAsync(T input);
        ICollection<T> RawSqlQuery(T entity, string sql);
        Task<T> FindAsync(int id);
        Task<T> FindAsync(Expression<Func<T, bool>> filter = null);
        Task<IList<T>> FindAllAsync(Expression<Func<T, bool>> filter = null);

        Task<IQueryable<T>> FindAllIncludeAsync(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] include);
    }
}
