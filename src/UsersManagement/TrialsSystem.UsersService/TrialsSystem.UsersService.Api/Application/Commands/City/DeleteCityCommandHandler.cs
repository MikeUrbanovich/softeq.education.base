using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.CityDTOs;

namespace TrialsSystem.UsersService.Api.Application.Commands.City
{
    /// <summary>
    /// 
    /// </summary>
    public class DeleteCityCommandHandler : IRequestHandler<DeleteCityCommand, DeleteCityResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<DeleteCityResponse> Handle(DeleteCityCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new DeleteCityResponse());
        }
    }
}