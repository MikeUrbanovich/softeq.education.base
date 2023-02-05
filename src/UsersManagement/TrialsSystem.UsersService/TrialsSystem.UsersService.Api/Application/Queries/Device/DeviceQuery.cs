using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.DeviceDTOs;

namespace TrialsSystem.UsersService.Api.Application.Queries.Device
{
    /// <summary>
    /// 
    /// </summary>
    public class DeviceQuery : IRequest<GetDeviceResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public string? Id { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public DeviceQuery(string? id)
        {
            Id = id;
        }
    }
}