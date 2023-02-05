using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Application.Queries.User
{
    /// <summary>
    /// 
    /// </summary>
    public class UserQueryHandler : IRequestHandler<UserQuery, GetUserResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public UserQueryHandler()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<GetUserResponse> Handle(UserQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new GetUserResponse());
        }
    }
}