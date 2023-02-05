using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.CityDTOs;

namespace TrialsSystem.UsersService.Api.Application.Queries.City
{
    /// <summary>
    /// 
    /// </summary>
    public class CitiesQuery : IRequest<IEnumerable<GetCitiesResponse>>
    {
        /// <summary>
        /// 
        /// </summary>
        public int? Take { get; }

        /// <summary>
        /// 
        /// </summary>
        public int? Skip { get; }

        /// <summary>
        /// 
        /// </summary>
        public string? Id { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="take"></param>
        /// <param name="skip"></param>
        public CitiesQuery(int? take, int? skip)
        {
            Take = take;
            Skip = skip;
        }
    }
}