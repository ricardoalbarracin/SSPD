using Core.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infrastructure.Data.Repositorios
{

    public abstract class SqlserverGenericRepository<D, T> : IGenericRepository<T>
           where T : class
           where D : DbContext
    {
        protected D _context;
        

        protected SqlserverGenericRepository(D context)
        {
            _context = context;
        }

        public abstract Task<T> GetById(T entity);

        public virtual async Task<IEnumerable<T>> GetAll(params Expression<Func<T, object>>[] including)
        {
            IQueryable<T> query = GetQueryable();

            if (including != null)
            {
                including.ToList().ForEach(include =>
                {
                    if (include != null)
                    {
                        query = query.Include(include);
                    }
                });
            }
            var result = await query.ToListAsync();
            return result;
        }

        public virtual async Task<IEnumerable<T>> GetByCriteria(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] including)
        {
            IQueryable<T> query = GetQueryable();

            if (including != null)
            {
                including.ToList().ForEach(include =>
                {
                    if (include != null)
                    {
                        query = query.Include(include);
                    }
                });
            }
            var result = await query.Where(filter).ToListAsync();

            return result;
        }

        public virtual async Task<IEnumerable<T>> GetByCriteria(
            Expression<Func<T, bool>> filter,
            List<Expression<Func<T, object>>> includes = null,
            int? page = null,
            int? pageSize = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null)
        {
            IQueryable<T> query = GetQueryable();

            if (includes != null)
            {
                includes.ToList().ForEach(include =>
                {
                    if (include != null)
                    {
                        query = query.Include(include);
                    }
                });
            }
            query = query.Where(filter);

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            if (page != null && pageSize != null)
            {
                query = query.Skip((page.Value - 1) * pageSize.Value).Take(pageSize.Value);
            }

            var result = await query.ToListAsync();
            return result;
        }

        public virtual async Task<IEnumerable<T>> GetByCriteria(IQueryable<T> queryable,
          List<Expression<Func<T, object>>> includes = null,
          int? page = null, int? pageSize = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null)
        {
            var query = queryable;

            if (includes != null)
            {
                includes.ToList().ForEach(include =>
                {
                    if (include != null)
                    {
                        query = query.Include(include);
                    }
                });
            }
            if (orderBy != null)
            {
                query = orderBy(query);
            }

            if (page != null && pageSize != null)
            {
                query = query.Skip((page.Value - 1) * pageSize.Value).Take(pageSize.Value);
            }

            var result = await query.ToListAsync();

            return result;
        }

        public virtual async Task<T> GetSingleByCriteria(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] including)
        {
            IQueryable<T> query = GetQueryable();

            if (including != null)
            {
                including.ToList().ForEach(include =>
                {
                    if (include != null)
                    {
                        query = query.Include(include);
                    }
                });
            }
            var result = await query
                .SingleOrDefaultAsync(filter);
            return result;

        }

        public virtual async Task Update(T entity)
        {
            _context.Set<T>().Update(entity);

            
            await _context.SaveChangesAsync(); 
            _context.ChangeTracker.Clear(); 
            
        }

        public virtual async Task Delete(T entity)
        {
            var resultGet = await GetById(entity);

            _context.Set<T>().Remove(resultGet);
            await _context.SaveChangesAsync();
            _context.ChangeTracker.Clear();
        }

        public virtual async Task<T> Add(T entity)
        {
            var result = _context.Set<T>().Add(entity);

            await _context.SaveChangesAsync();
            _context.ChangeTracker.Clear();
            return result.Entity;
        }

        public virtual async Task<IEnumerable<T>> AddRange(IEnumerable<T> entity)
        {
            _context.Set<T>().AddRange(entity);
            await _context.SaveChangesAsync();
            _context.ChangeTracker.Clear();
            return entity;
        }

        public async Task<int> Count(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = GetQueryable();
            if (includes != null)
            {
                includes.ToList().ForEach(include =>
                {
                    if (include != null)
                    {
                        query = query.Include(include);
                    }
                });
            }
            var result = await query.CountAsync(filter);

            return result;
        }

        public async Task<int> Count(IQueryable<T> data, params Expression<Func<T, object>>[] includes)
        {
            var query = data;

            if (includes != null)
            {
                includes.ToList().ForEach(include =>
                {
                    if (include != null)
                    {
                        query = query.Include(include);
                    }
                });
            }
            var result = await query.CountAsync();
            return result;
        }


        public IQueryable<T> AsQueryable(params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = GetQueryable();
            if (includes != null)
            {
                includes.ToList().ForEach(include =>
                {
                    if (include != null)
                    {
                        query = query.Include(include);
                    }
                });
            }
            return query;
        }

        public Task<List<object>> ToListAsync(IQueryable<object> query)
        {
            return query.ToListAsync();
        }


       

        private IQueryable<T> GetQueryable()
        {

            IQueryable<T> query;
            query = _context.Set<T>().AsNoTracking().AsQueryable();
            return query;
        }


    }

}
