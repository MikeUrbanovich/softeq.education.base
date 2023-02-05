using Microsoft.Extensions.Logging;
using TrialsSystem.UsersService.Infrastructure.Configuration;
using TrialsSystem.UsersService.Infrastructure.Repositories;

namespace TrialsSystem.UsersService.Infrastructure.Context
{
    public class UnitOfWork : IUnitOfWork
    {
        public IUserRepository Users { get; }
        public ICityRepository Cities { get; }
        public IDeviceRepository Devices { get; }

        public UnitOfWork(UsersServiceContext context)
        {
            Users = new UserRepository(context);
            Cities = new CityRepository(context);
            Devices = new DeviceRepository(context);
        }
    }
}