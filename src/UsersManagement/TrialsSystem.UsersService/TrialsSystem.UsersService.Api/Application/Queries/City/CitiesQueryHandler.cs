using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.CityDTOs;

namespace TrialsSystem.UsersService.Api.Application.Queries.City
{
    public class CitiesQueryHandler : IRequestHandler<CitiesQuery, IEnumerable<GetCitiesResponse>>
    {
        public CitiesQueryHandler()
        {

        }

        public async Task<IEnumerable<GetCitiesResponse>> Handle(CitiesQuery request, CancellationToken cancellationToken)
        {
            return new List<GetCitiesResponse>();
        }
    }
}
