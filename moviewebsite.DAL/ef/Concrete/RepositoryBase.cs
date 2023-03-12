using Microsoft.EntityFrameworkCore;
using moviewebsite.DAL.ef.Abstract;
using moviewebsite.Entities.Abstract;
using moviewebsite.Entities.Concrete;
using moviewebsite.Entities.Context;
using System.Linq.Expressions;

namespace moviewebsite.DAL.ef.Concrete
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : BaseEntity, new()
    {
        protected SqlDbcontext dbcontext;
        public RepositoryBase()
        {
            dbcontext = new SqlDbcontext();
        }
        public async Task<int> AddAsync(T input)
        {
            await dbcontext.Set<T>().AddAsync(input);
            return await dbcontext.SaveChangesAsync();
        }

        public void AddAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public async Task<int> DeleteAsync(T input)
        {
            dbcontext.Remove<T>(input);
            return await dbcontext.SaveChangesAsync();
        }

        public async Task<IList<T>> FindAllAsync(Expression<Func<T, bool>> filter = null)
        {
            if (filter == null)
                return await dbcontext.Set<T>().Where(filter).ToListAsync();
            else
                return await dbcontext.Set<T>().ToListAsync();
        }

        public async Task<IQueryable<T>> FindAllIncludeAsync(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] include)
        {
            var query = dbcontext.Set<T>();
            if (filter != null)
                query.Where(filter);
            return include.Aggregate(query.AsQueryable(), (current, includeprop) => current.Include(includeprop));
        }

        public async Task<T> FindAsync(int id)
        {
            return await dbcontext.FindAsync<T>(id);
        }

        public async Task<T> FindAsync(Expression<Func<T, bool>> filter = null)
        {
            return await dbcontext.Set<T>().Where(filter).FirstOrDefaultAsync();
        }

        public ICollection<T> RawSqlQuery(T entity, string sql)
        {
            var sonuc = dbcontext.Set<T>().FromSqlRaw(sql).IgnoreQueryFilters().ToList();
            return sonuc;
        }

        public async Task<int> UpdateAsync(T input)
        {
            dbcontext.Update<T>(input);
            return await dbcontext.SaveChangesAsync();
        }
    }
}
