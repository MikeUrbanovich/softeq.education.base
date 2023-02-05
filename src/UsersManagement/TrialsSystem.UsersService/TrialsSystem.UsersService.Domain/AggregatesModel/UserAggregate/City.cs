using TrialsSystem.UsersService.Domain.AggregatesModel.Base;

namespace TrialsSystem.UsersService.Domain.AggregatesModel.UserAggregate
{
    public class City : Entity
    {
        public City(string name, Guid id)
        {
            Name = name;
            CreatedDate = DateTime.UtcNow;
            LastModifiedDate = DateTime.UtcNow;
            Id = id;
        }

        public string Name { get; set; }
    }
}