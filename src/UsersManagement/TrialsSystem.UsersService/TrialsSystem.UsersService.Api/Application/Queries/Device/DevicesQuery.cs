using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.DeviceDTOs;

namespace TrialsSystem.UsersService.Api.Application.Queries.Device
{
    public class DevicesQuery : IRequest<IEnumerable<GetDevicesResponse>>
    {
        public int? Take { get; }

        public int? Skip { get; }

        public DevicesQuery(int? take, int? skip)
        {
            Take = take;
            Skip = skip;
        }
    }
}
