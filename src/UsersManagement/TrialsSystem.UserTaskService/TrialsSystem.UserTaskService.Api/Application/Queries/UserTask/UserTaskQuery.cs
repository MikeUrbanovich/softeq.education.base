using MediatR;
using TrialsSystem.UserTaskService.Infrastructure.Models.UserTaskDTOs;

namespace TrialsSystem.UserTaskService.Api.Application.Queries.UserTask
{
    public class UserTaskQuery : IRequest<GetUserTaskResponse>
    {
        public string? Id { get; }

        public UserTaskQuery(string? id)
        {
            Id = id;
        }
    }
}
