using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.CityDTOs;

namespace TrialsSystem.UsersService.Api.Application.Queries.City
{
    public class CityQuery : IRequest<GetCityResponse>
    {
        public string? Id { get; }

        public CityQuery(string? id)
        {
            Id = id;
        }
    }
}
