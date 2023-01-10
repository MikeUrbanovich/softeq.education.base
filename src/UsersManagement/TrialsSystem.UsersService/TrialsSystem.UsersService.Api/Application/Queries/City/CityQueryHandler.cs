using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.CityDTOs;

namespace TrialsSystem.UsersService.Api.Application.Queries.City
{
    public class CityQueryHandler : IRequestHandler<CityQuery, GetCityResponse>
    {
        public CityQueryHandler()
        {

        }

        public async Task<GetCityResponse> Handle(CityQuery request, CancellationToken cancellationToken)
        {
            return new GetCityResponse();
        }
    }
}
