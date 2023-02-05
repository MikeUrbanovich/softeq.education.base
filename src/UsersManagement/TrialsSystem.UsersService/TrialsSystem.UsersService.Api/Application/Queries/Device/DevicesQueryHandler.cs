using AutoMapper;
using MediatR;
using TrialsSystem.UsersService.Infrastructure.Configuration;
using TrialsSystem.UsersService.Infrastructure.Models.CityDTOs;
using TrialsSystem.UsersService.Infrastructure.Models.DeviceDTOs;

namespace TrialsSystem.UsersService.Api.Application.Queries.Device
{
    /// <summary>
    /// 
    /// </summary>
    public class DevicesQueryHandler : IRequestHandler<DevicesQuery, IEnumerable<GetDevicesResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        /// <summary>
        /// 
        /// </summary>
        public DevicesQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<IEnumerable<GetDevicesResponse>> Handle(
            DevicesQuery request,
            CancellationToken cancellationToken)
        {
            var devices = await _unitOfWork.Devices.GetAllAsync();

            return _mapper.Map<IEnumerable<GetDevicesResponse>>(devices);
        }
    }
}