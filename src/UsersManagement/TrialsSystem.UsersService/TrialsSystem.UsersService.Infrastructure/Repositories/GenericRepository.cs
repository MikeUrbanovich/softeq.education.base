using Microsoft.EntityFrameworkCore;
using TrialsSystem.UsersService.Infrastructure.Configuration;
using TrialsSystem.UsersService.Infrastructure.Context;

namespace TrialsSystem.UsersService.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        internal UsersServiceContext applicationContext;
        internal DbSet<T> dbSet;

        public GenericRepository(
            UsersServiceContext context)
        {
            applicationContext = context;
            dbSet = context.Set<T>();
        }

        public virtual Task<T> AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await dbSet.ToListAsync();
        }

        public virtual Task<T> GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}