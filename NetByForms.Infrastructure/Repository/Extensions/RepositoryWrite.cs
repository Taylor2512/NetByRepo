using NetByForms.Infrastructure.DataAcces;
using NetByForms.Infrastructure.Repository.Extensions.Interfaces;

namespace NetByForms.Infrastructure.Repository.Extensions
{
    public class RepositoryWrite<T>(ApplicationDbContext context) : IRepositoryWrite<T> where T : class
    {
        public void Add(T entity)
        {
            _ = context.Set<T>().Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            context.Set<T>().AddRange(entities);
        }

        public void Remove(T entity)
        {
            _ = context.Set<T>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            context.Set<T>().RemoveRange(entities);
        }

        public async Task SaveChangesAsync()
        {
            _ = await context.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            _ = context.Set<T>().Update(entity);
        }

        public void UpdateRange(IEnumerable<T> entities)
        {
            context.Set<T>().UpdateRange(entities);
        }
    }
}