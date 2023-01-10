using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.DeviceDTOs;

namespace TrialsSystem.UsersService.Api.Application.Commands.Device
{
    public class UpdateDeviceCommand : IRequest<UpdateDeviceResponse>
    {
        public UpdateDeviceCommand(string id,
            string firmwareVersion)
        {
            Id = id;
            FirmwareVersion = firmwareVersion;
        }

        public string Id { get; }

        public string FirmwareVersion { get; }
    }
}
