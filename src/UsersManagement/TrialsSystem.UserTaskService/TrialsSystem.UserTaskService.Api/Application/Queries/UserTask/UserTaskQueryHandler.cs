using MediatR;
using TrialsSystem.UserTaskService.Infrastructure.Models.UserTaskDTOs;

namespace TrialsSystem.UserTaskService.Api.Application.Queries.UserTask
{
    public class UserTaskQueryHandler : IRequestHandler<UserTaskQuery, GetUserTaskResponse>
    {
        public UserTaskQueryHandler()
        {

        }

        public async Task<GetUserTaskResponse> Handle(UserTaskQuery request, CancellationToken cancellationToken)
        {
            return new GetUserTaskResponse();
        }
    }
}
