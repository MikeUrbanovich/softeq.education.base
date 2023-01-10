using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.CityDTOs;

namespace TrialsSystem.UsersService.Api.Application.Queries.City
{
    public class CitiesQuery : IRequest<IEnumerable<GetCitiesResponse>>
    {
        public int? Take { get; }

        public int? Skip { get; }

        public string? Id { get; }

        public CitiesQuery(int? take, int? skip)
        {
            Take = take;
            Skip = skip;
        }
    }
}
