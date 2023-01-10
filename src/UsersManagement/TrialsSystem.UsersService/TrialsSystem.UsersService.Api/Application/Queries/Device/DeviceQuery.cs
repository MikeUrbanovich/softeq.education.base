using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.DeviceDTOs;

namespace TrialsSystem.UsersService.Api.Application.Queries.Device
{
    public class DeviceQuery : IRequest<GetDeviceResponse>
    {
        public string? Id { get; }

        public DeviceQuery(string? id)
        {
            Id = id;
        }
    }
}
