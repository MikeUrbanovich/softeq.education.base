using MediatR;
using TrialsSystem.UserTaskService.Infrastructure.Models.UserTaskDTOs;

namespace TrialsSystem.UserTaskService.Api.Application.Queries.UserTask
{
    public class UserTasksQuery : IRequest<IEnumerable<GetUserTasksResponse>>
    {
        public int? Take { get; }

        public int? Skip { get; }


        public UserTasksQuery(int? take, int? skip)
        {
            Take = take;
            Skip = skip;
        }
    }
}
