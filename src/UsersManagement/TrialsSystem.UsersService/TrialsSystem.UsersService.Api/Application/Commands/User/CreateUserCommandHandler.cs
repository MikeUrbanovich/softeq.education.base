using Azure.Core;
using MediatR;
using TrialsSystem.UsersService.Infrastructure.Configuration;
using TrialsSystem.UsersService.Infrastructure.Models.CityDTOs;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Application.Commands.User
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, CreateUserResponse>
    {
        private readonly IUnitOfWork _unitOfWork;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="unitOfWork"></param>
        public CreateUserCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<CreateUserResponse> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var newUser = new Domain.AggregatesModel.UserAggregate.User(Guid.NewGuid(),
                request.Email,
                request.Name,
                request.Surname,
                request.CityId,
                request.GenderId,
                request.BirthDate);

            newUser.SetHeight(request.Height);
            newUser.SetWeight(request.Weight);

            var user = await _unitOfWork.Users
                .AddAsync(newUser)!;

            return new CreateUserResponse { Id = user.Id };
        }
    }
}