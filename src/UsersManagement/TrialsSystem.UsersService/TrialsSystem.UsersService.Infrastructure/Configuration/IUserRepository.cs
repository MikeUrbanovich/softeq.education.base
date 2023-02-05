using TrialsSystem.UsersService.Domain.AggregatesModel.UserAggregate;

namespace TrialsSystem.UsersService.Infrastructure.Configuration
{
    public interface IUserRepository : IGenericRepository<User>
    {
    }
}