using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.DeviceDTOs;

namespace TrialsSystem.UsersService.Api.Application.Commands.Device
{
    public class DeleteDeviceCommandHandler : IRequestHandler<DeleteDeviceCommand, DeleteDeviceResponse>
    {
        public async Task<DeleteDeviceResponse> Handle(DeleteDeviceCommand request, CancellationToken cancellationToken)
        {
            return new DeleteDeviceResponse();
        }
    }
}
