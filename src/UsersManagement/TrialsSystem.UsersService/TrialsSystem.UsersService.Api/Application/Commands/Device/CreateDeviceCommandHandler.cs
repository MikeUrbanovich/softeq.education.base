using AutoMapper;
using MediatR;
using TrialsSystem.UsersService.Infrastructure.Configuration;
using TrialsSystem.UsersService.Infrastructure.Models.DeviceDTOs;

namespace TrialsSystem.UsersService.Api.Application.Commands.Device
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateDeviceCommandHandler : IRequestHandler<CreateDeviceCommand, CreateDeviceResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="unitOfWork"></param>
        /// <param name="mapper"></param>
        public CreateDeviceCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
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
        public async Task<CreateDeviceResponse> Handle(CreateDeviceCommand request, CancellationToken cancellationToken)
        {
            var device = await _unitOfWork.Devices
                .AddAsync(new Domain.AggregatesModel.DeviceAggregate.Device(
                    Guid.NewGuid(),
                    request.SerialNumber,
                    request.Model,
                    request.TypeId,
                    request.FirmwareVersion))!;

            return _mapper.Map<CreateDeviceResponse>(device);
        }
    }
}