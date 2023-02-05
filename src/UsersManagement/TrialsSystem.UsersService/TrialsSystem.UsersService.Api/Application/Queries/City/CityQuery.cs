using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.CityDTOs;

namespace TrialsSystem.UsersService.Api.Application.Queries.City
{
    /// <summary>
    /// 
    /// </summary>
    public class CityQuery : IRequest<GetCityResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public string? Id { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public CityQuery(string? id)
        {
            Id = id;
        }
    }
}