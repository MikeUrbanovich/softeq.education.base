using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.CityDTOs;

namespace TrialsSystem.UsersService.Api.Application.Commands.City
{
    public class CreateCityCommand : IRequest<CreateCityResponse>
    {
        public CreateCityCommand(string name) 
        {
            Name = name;
        }

        public string Name { get; }
    }
}
