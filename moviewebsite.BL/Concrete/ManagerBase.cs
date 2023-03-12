using moviewebsite.BL.Abstract;
using moviewebsite.DAL.ef.Abstract;
using moviewebsite.DAL.ef.Concrete;
using moviewebsite.Entities.Abstract;
using System.Linq.Expressions;

namespace moviewebsite.BL.Concrete
{
    public class ManagerBase<T> : IManagerBase<T> where T : BaseEntity, new()
    {
        protected IRepositoryBase<T> _repositoryBase;
        public ManagerBase()
        {
            _repositoryBase = new RepositoryBase<T>();
        }

        public async virtual Task<int> AddAsync(T input)
        {
            return await _repositoryBase.AddAsync(input);
        }

        public async virtual Task<int> DeleteAsync(T input)
        {
            return await _repositoryBase.DeleteAsync(input);
        }

        public async Task<IList<T>> FindAllAsync(Expression<Func<T, bool>> filter = null)
        {
            return await _repositoryBase.FindAllAsync(filter);
        }

        public async Task<IQueryable<T>> FindAllIncludeAsync(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] include)
        {
            return await _repositoryBase.FindAllIncludeAsync(filter, include);
        }

        public async Task<T> FindAsync(int id)
        {
            return await _repositoryBase.FindAsync(id);
        }

        public async Task<T> FindAsync(Expression<Func<T, bool>> filter = null)
        {
            return await _repositoryBase.FindAsync(filter);
        }

        public ICollection<T> RawSqlQuery(T entity, string sql)
        {
            return _repositoryBase.RawSqlQuery(entity, sql);

        }

        public async virtual Task<int> UpdateAsync(T input)
        {
            return await _repositoryBase.UpdateAsync(input);
        }
    }
}
