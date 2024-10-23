using System.Linq.Expressions;

namespace NetByForms.Infrastructure.Repository.Extensions.Interfaces
{
    public interface IRepositoryRead<T> where T : class
    {
        Task<T?> GetByIdAsync<TId>(TId id);

        Task<IEnumerable<T>> GetAllAsync();

        Task<IEnumerable<T>> GetWithIncludeAsync(
           Expression<Func<T, bool>> predicate,
           params Expression<Func<T, object>>[] includes);

        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);

    }
}
