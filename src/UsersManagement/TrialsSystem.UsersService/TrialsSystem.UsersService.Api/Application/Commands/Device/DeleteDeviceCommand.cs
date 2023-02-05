using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.DeviceDTOs;

namespace TrialsSystem.UsersService.Api.Application.Commands.Device
{
    /// <summary>
    /// 
    /// </summary>
    public class DeleteDeviceCommand : IRequest<DeleteDeviceResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public DeleteDeviceCommand(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Id { get; }
    }
}