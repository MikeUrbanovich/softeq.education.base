using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Application.Commands.User
{
    public class DeleteUserCommand : IRequest<DeleteUserResponse>
    {
        public DeleteUserCommand(string id)
        {
            Id = id;
        }

        public string Id { get; }
    }
}
