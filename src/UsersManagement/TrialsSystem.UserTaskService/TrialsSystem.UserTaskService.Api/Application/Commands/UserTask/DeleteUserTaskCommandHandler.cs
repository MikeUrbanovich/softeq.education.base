using MediatR;
using TrialsSystem.UserTaskService.Infrastructure.Models.UserTaskDTOs;

namespace TrialsSystem.UserTaskService.Api.Application.Commands.UserTask
{
    public class DeleteUserTaskCommandHandler : IRequestHandler<DeleteUserTaskCommand, DeleteUserTaskResponse>
    {
        public async Task<DeleteUserTaskResponse> Handle(DeleteUserTaskCommand request, CancellationToken cancellationToken)
        {
            return new DeleteUserTaskResponse();
        }
    }
}
