using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.DeviceDTOs;

namespace TrialsSystem.UsersService.Api.Application.Queries.Device
{
    /// <summary>
    /// 
    /// </summary>
    public class DeviceQueryHandler : IRequestHandler<DeviceQuery, GetDeviceResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public DeviceQueryHandler()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<GetDeviceResponse> Handle(DeviceQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new GetDeviceResponse());
        }
    }
}