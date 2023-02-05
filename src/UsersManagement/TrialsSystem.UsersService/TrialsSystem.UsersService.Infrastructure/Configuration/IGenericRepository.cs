namespace TrialsSystem.UsersService.Infrastructure.Configuration
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T>? GetById(Guid id);
        Task<T>? AddAsync(T entity);
    }
}