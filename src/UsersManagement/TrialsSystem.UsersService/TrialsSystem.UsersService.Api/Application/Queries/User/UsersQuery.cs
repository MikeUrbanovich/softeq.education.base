using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Application.Queries.User
{
    /// <summary>
    /// 
    /// </summary>
    public class UsersQuery : IRequest<IEnumerable<GetUsersResponse>>
    {
        /// <summary>
        /// 
        /// </summary>
        public int? Take { get; }

        /// <summary>
        /// 
        /// </summary>
        public int? Skip { get; }

        /// <summary>
        /// 
        /// </summary>
        public string? Email { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="take"></param>
        /// <param name="skip"></param>
        /// <param name="email"></param>
        public UsersQuery(int? take, int? skip, string? email)
        {
            Take = take;
            Skip = skip;
            Email = email;
        }
    }
}