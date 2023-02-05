using AutoMapper.Configuration.Annotations;

namespace TrialsSystem.UsersService.Infrastructure.Models.UserDTOs
{
    public class CreateUserRequest
    {
        public string Email { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime BirthDate { get; set; }

        public decimal? Weight { get; set; }

        public decimal? Height { get; set; }

        [Ignore]
        public Guid CityId { get; set; }

        [Ignore]
        public Guid GenderId { get; set; }
    }
}