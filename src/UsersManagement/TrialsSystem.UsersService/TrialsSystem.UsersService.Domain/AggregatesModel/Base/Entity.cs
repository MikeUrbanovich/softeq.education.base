using System.ComponentModel.DataAnnotations;

namespace TrialsSystem.UsersService.Domain.AggregatesModel.Base
{
    public class Entity
    {
        [Key]
        public Guid Id { get; protected set; }

        public bool IsDeleted { get; protected set; }

        public DateTime CreatedDate { get; protected set; }
        public DateTime LastModifiedDate { get; protected set; }
    }
}