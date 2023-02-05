using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Application.Queries.User
{
    /// <summary>
    /// 
    /// </summary>
    public class UserQuery : IRequest<GetUserResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public string? Id { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public UserQuery(string? id)
        {
            Id = id;
        }
    }
}