using MediatR;
using TrialsSystem.UserTaskService.Infrastructure.Models.UserTaskDTOs;

namespace TrialsSystem.UserTaskService.Api.Application.Queries.UserTask
{
    public class UserTasksQueryHandler : IRequestHandler<UserTasksQuery, IEnumerable<GetUserTasksResponse>>
    {
        public UserTasksQueryHandler()
        {

        }

        public async Task<IEnumerable<GetUserTasksResponse>> Handle(UserTasksQuery request, CancellationToken cancellationToken)
        {
            return new List<GetUserTasksResponse>();
        }
    }
}
