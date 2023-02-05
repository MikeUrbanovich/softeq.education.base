using MediatR;
using TrialsSystem.UsersService.Infrastructure.Configuration;
using TrialsSystem.UsersService.Infrastructure.Models.CityDTOs;

namespace TrialsSystem.UsersService.Api.Application.Queries.City
{
    /// <summary>
    /// 
    /// </summary>
    public class CityQueryHandler : IRequestHandler<CityQuery, GetCityResponse>
    {
        private readonly IUnitOfWork _unitOfWork;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="unitOfWork"></param>
        public CityQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<GetCityResponse> Handle(CityQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new GetCityResponse());
        }
    }
}