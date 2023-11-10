using System.Linq.Expressions;
namespace Core.Data
{
    public interface IGenericRepository<T>
    {

        Task<T> GetById(T entity);

        Task<IEnumerable<T>> GetAll(params Expression<Func<T, object>>[] including);

        Task<IEnumerable<T>> GetByCriteria(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] including);
        Task<IEnumerable<T>> GetByCriteria(Expression<Func<T, bool>> filter,
                                            List<Expression<Func<T, object>>> includes = null, 
                                            int? page = null, 
                                            int? pageSize = null, 
                                            Func<IQueryable<T>, 
                                            IOrderedQueryable<T>> orderBy = null);

        Task<int> Count(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] includes);
        Task<int> Count(IQueryable<T> data, params Expression<Func<T, object>>[] includes);

        Task<T> GetSingleByCriteria(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] including);

        Task Update(T entity);

        Task Delete(T entity);

        Task<T> Add(T entity);

        Task<IEnumerable<T>> AddRange(IEnumerable<T> entity);

        IQueryable<T> AsQueryable(params Expression<Func<T, object>>[] includes);
        Task<List<object>> ToListAsync(IQueryable<object> query);
        Task<IEnumerable<T>> GetByCriteria(IQueryable<T> queryable,
        List<Expression<Func<T, object>>> includes = null,
        int? page = null, int? pageSize = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null);

    }
}
