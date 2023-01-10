using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.DeviceDTOs;

namespace TrialsSystem.UsersService.Api.Application.Commands.Device
{
    public class DeleteDeviceCommand : IRequest<DeleteDeviceResponse>
    {
        public DeleteDeviceCommand(string id)
        {
            Id = id;
        }

        public string Id { get; }
    }
}
