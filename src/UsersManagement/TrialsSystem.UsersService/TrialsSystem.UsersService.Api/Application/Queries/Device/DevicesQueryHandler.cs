using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.DeviceDTOs;

namespace TrialsSystem.UsersService.Api.Application.Queries.Device
{
    public class DevicesQueryHandler : IRequestHandler<DevicesQuery, IEnumerable<GetDevicesResponse>>
    {
        public DevicesQueryHandler()
        {

        }

        public async Task<IEnumerable<GetDevicesResponse>> Handle(DevicesQuery request, CancellationToken cancellationToken)
        {
            return new List<GetDevicesResponse>();
        }
    }
}
