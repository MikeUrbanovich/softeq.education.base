using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Application.Commands.User
{
    /// <summary>
    /// 
    /// </summary>
    public class DeleteUserCommand : IRequest<DeleteUserResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public DeleteUserCommand(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Id { get; }
    }
}