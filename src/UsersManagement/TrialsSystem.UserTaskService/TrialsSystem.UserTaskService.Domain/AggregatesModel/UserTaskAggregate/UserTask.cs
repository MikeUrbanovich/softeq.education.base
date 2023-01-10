using TrialsSystem.UserTaskService.Domain.AggregatesModel.Base;

namespace TrialsSystem.UserTaskService.Domain.AggregatesModel.UserTaskAggregate
{
    public class UserTask : Entity
    {
        public UserTask(UserTaskStatus status)
        {
            Status = status;
            AdditionalProperties = new Dictionary<string, string>();
        }

        public UserTaskStatus Status { get; private set; }
        public IDictionary<string, string> AdditionalProperties { get; private set; }
    }
}
