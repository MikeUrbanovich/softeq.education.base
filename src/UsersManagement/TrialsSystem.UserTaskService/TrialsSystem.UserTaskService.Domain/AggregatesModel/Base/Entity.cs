namespace TrialsSystem.UserTaskService.Domain.AggregatesModel.Base
{
    public class Entity
    {
        public string Id { get; protected set; }
        public bool IsDeleted { get; protected set; }

        public DateTime CreatedDate { get; protected set; }
        public DateTime LastUpdatedDateTime { get; protected set; }

    }
}
