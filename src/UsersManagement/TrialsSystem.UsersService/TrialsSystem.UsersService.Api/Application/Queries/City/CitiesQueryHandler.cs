using MediatR;
using TrialsSystem.UsersService.Infrastructure.Configuration;
using TrialsSystem.UsersService.Infrastructure.Models.CityDTOs;

namespace TrialsSystem.UsersService.Api.Application.Queries.City
{
    /// <summary>
    /// 
    /// </summary>
    public class CitiesQueryHandler : IRequestHandler<CitiesQuery, IEnumerable<GetCitiesResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="unitOfWork"></param>
        public CitiesQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<IEnumerable<GetCitiesResponse>> Handle(
            CitiesQuery request,
            CancellationToken cancellationToken)
        {
            var cities = await _unitOfWork.Cities.GetAllAsync();

            return cities.Select(c => new GetCitiesResponse { Name = c.Name }).ToList();
        }
    }
}