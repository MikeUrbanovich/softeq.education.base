using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Application.Queries.User
{
    public class UserQuery : IRequest<GetUserResponse>
    {
        public string? Id { get; }

        public UserQuery(string? id)
        {
            Id = id;
        }
    }
}
