using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.DeviceDTOs;

namespace TrialsSystem.UsersService.Api.Application.Commands.Device
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateDeviceCommand : IRequest<UpdateDeviceResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="firmwareVersion"></param>
        public UpdateDeviceCommand(
            string id,
            string firmwareVersion)
        {
            Id = id;
            FirmwareVersion = firmwareVersion;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// 
        /// </summary>
        public string FirmwareVersion { get; }
    }
}