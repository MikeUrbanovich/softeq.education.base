using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TrialsSystem.UsersService.Domain.AggregatesModel.UserAggregate;
using TrialsSystem.UsersService.Infrastructure.Configuration;
using TrialsSystem.UsersService.Infrastructure.Context;

namespace TrialsSystem.UsersService.Infrastructure.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(UsersServiceContext context) : base(context)
        {
        }

        public override async Task<User> AddAsync(User user)
        {
            applicationContext.Users.Add(user);

            await applicationContext.Entry(user).Reference(x => x.City).LoadAsync();
            await applicationContext.Entry(user).Reference(x => x.Gender).LoadAsync();

            await applicationContext.SaveChangesAsync();

            return user;
        }

        public override async Task<IEnumerable<User>> GetAllAsync()
        {
            return await applicationContext.Users
                .Include(x => x.City)
                .Include(x => x.Gender)
                .ToListAsync();
        }
    }
}