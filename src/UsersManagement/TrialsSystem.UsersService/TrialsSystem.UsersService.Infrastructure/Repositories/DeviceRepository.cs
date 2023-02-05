using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TrialsSystem.UsersService.Domain.AggregatesModel.DeviceAggregate;
using TrialsSystem.UsersService.Infrastructure.Configuration;
using TrialsSystem.UsersService.Infrastructure.Context;

namespace TrialsSystem.UsersService.Infrastructure.Repositories
{
    internal class DeviceRepository : GenericRepository<Device>, IDeviceRepository
    {
        public DeviceRepository(UsersServiceContext context) : base(context)
        {
        }

        public override async Task<Device> AddAsync(Device device)
        {
            await base.AddAsync(device)!;

            applicationContext.Devices.Add(device);

            await applicationContext.Entry(device).Reference(x => x.Type).LoadAsync();

            await applicationContext.SaveChangesAsync();

            return device;
        }

        public override async Task<IEnumerable<Device>> GetAllAsync()
        {
            return await applicationContext.Devices
                .Include(x => x.Type)
                .ToListAsync();
        }
    }
}