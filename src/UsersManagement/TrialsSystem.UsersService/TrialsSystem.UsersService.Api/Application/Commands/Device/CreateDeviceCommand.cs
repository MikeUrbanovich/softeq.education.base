using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.DeviceDTOs;

namespace TrialsSystem.UsersService.Api.Application.Commands.Device
{
    public class CreateDeviceCommand : IRequest<CreateDeviceResponse>
    {
        public CreateDeviceCommand(string serialNumber,
            string model,
            string typeId,
            string firmwareVersion
            )
        {
            SerialNumber = serialNumber;
            Model = model;
            TypeId = typeId;
            FirmwareVersion = firmwareVersion;
        }

        public string SerialNumber { get; }

        public string Model { get; }

        public string TypeId { get; }

        public string FirmwareVersion { get; }
    }
}
