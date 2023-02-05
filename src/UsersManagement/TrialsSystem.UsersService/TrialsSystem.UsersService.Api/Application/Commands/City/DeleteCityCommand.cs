using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.CityDTOs;

namespace TrialsSystem.UsersService.Api.Application.Commands.City
{
    /// <summary>
    /// 
    /// </summary>
    public class DeleteCityCommand : IRequest<DeleteCityResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public DeleteCityCommand(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Id { get; }
    }
}