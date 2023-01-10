using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.CityDTOs;

namespace TrialsSystem.UsersService.Api.Application.Commands.City
{
    public class DeleteCityCommandHandler : IRequestHandler<DeleteCityCommand, DeleteCityResponse>
    {
        public async Task<DeleteCityResponse> Handle(DeleteCityCommand request, CancellationToken cancellationToken)
        {
            return new DeleteCityResponse();
        }
    }
}
