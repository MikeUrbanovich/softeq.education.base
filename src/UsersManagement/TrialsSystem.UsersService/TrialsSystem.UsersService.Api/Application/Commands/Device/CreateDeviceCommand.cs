using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.DeviceDTOs;

namespace TrialsSystem.UsersService.Api.Application.Commands.Device
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateDeviceCommand : IRequest<CreateDeviceResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="serialNumber"></param>
        /// <param name="model"></param>
        /// <param name="typeId"></param>
        /// <param name="firmwareVersion"></param>
        public CreateDeviceCommand(
            string serialNumber,
            string model,
            Guid typeId,
            string firmwareVersion
        )
        {
            SerialNumber = serialNumber;
            Model = model;
            TypeId = typeId;
            FirmwareVersion = firmwareVersion;
        }

        /// <summary>
        /// 
        /// </summary>
        public string SerialNumber { get; }

        /// <summary>
        /// 
        /// </summary>
        public string Model { get; }

        /// <summary>
        /// 
        /// </summary>
        public Guid TypeId { get; }

        /// <summary>
        /// 
        /// </summary>
        public string FirmwareVersion { get; }
    }
}