using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.CityDTOs;

namespace TrialsSystem.UsersService.Api.Application.Commands.City
{
    public class DeleteCityCommand : IRequest<DeleteCityResponse>
    {
        public DeleteCityCommand(string id)
        {
            Id = id;
        }

        public string Id { get; }
    }
}
