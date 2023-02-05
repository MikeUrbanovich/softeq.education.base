using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.DeviceDTOs;

namespace TrialsSystem.UsersService.Api.Application.Commands.Device
{
    /// <summary>
    /// 
    /// </summary>
    public class DeleteDeviceCommandHandler : IRequestHandler<DeleteDeviceCommand, DeleteDeviceResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<DeleteDeviceResponse> Handle(DeleteDeviceCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new DeleteDeviceResponse());
        }
    }
}