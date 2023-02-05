using TrialsSystem.UsersService.Domain.AggregatesModel.UserAggregate;
using TrialsSystem.UsersService.Infrastructure.Configuration;
using TrialsSystem.UsersService.Infrastructure.Context;
using Microsoft.Extensions.Logging;

namespace TrialsSystem.UsersService.Infrastructure.Repositories
{
    public class CityRepository : GenericRepository<City>, ICityRepository
    {
        public CityRepository(UsersServiceContext context) : base(context)
        {
        }

        public override async Task<City> AddAsync(City city)
        {
            applicationContext.Cities.Add(city);

            await applicationContext.SaveChangesAsync();

            return city;
        }
    }
}