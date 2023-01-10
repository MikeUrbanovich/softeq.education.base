using MediatR;
using TrialsSystem.UserTaskService.Infrastructure.Models.UserTaskDTOs;

namespace TrialsSystem.UserTaskService.Api.Application.Commands.UserTask
{
    public class DeleteUserTaskCommand : IRequest<DeleteUserTaskResponse>
    {
        public DeleteUserTaskCommand(string id)
        {
            Id = id;
        }

        public string Id { get; }
    }
}
