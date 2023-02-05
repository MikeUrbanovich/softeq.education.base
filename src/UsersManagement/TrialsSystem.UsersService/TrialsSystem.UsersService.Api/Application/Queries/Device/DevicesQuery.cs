using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.DeviceDTOs;

namespace TrialsSystem.UsersService.Api.Application.Queries.Device
{
    /// <summary>
    /// 
    /// </summary>
    public class DevicesQuery : IRequest<IEnumerable<GetDevicesResponse>>
    {
        /// <summary>
        /// 
        /// </summary>
        public int? Take { get; }

        /// <summary>
        /// 
        /// </summary>
        public int? Skip { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="take"></param>
        /// <param name="skip"></param>
        public DevicesQuery(int? take, int? skip)
        {
            Take = take;
            Skip = skip;
        }
    }
}