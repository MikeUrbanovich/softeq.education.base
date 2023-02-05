using MediatR;
using TrialsSystem.UsersService.Infrastructure.Configuration;
using TrialsSystem.UsersService.Infrastructure.Models.CityDTOs;

namespace TrialsSystem.UsersService.Api.Application.Commands.City
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateCityCommandHandler : IRequestHandler<CreateCityCommand, CreateCityResponse>
    {
        private readonly IUnitOfWork _unitOfWork;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="unitOfWork"></param>
        public CreateCityCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<CreateCityResponse> Handle(CreateCityCommand request, CancellationToken cancellationToken)
        {
            var city = await _unitOfWork.Cities
                .AddAsync(new Domain.AggregatesModel.UserAggregate.City(request.Name, Guid.NewGuid()))!;

            return new CreateCityResponse
            {
                Id = city.Id,
                Name = city.Name
            };
        }
    }
}