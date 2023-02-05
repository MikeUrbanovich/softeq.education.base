using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.CityDTOs;

namespace TrialsSystem.UsersService.Api.Application.Commands.City
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateCityCommand : IRequest<CreateCityResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public CreateCityCommand(string name)
        {
            Name = name;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; }
    }
}