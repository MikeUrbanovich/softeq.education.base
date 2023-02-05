using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.CityDTOs;

namespace TrialsSystem.UsersService.Api.Application.Commands.City
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateCityCommandHandler : IRequestHandler<UpdateCityCommand, UpdateCityResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<UpdateCityResponse> Handle(UpdateCityCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new UpdateCityResponse());
        }
    }
}