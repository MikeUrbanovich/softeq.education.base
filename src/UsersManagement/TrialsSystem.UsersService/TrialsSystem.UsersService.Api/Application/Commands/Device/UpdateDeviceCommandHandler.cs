using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.DeviceDTOs;

namespace TrialsSystem.UsersService.Api.Application.Commands.Device
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateDeviceCommandHandler : IRequestHandler<UpdateDeviceCommand, UpdateDeviceResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<UpdateDeviceResponse> Handle(UpdateDeviceCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new UpdateDeviceResponse());
        }
    }
}