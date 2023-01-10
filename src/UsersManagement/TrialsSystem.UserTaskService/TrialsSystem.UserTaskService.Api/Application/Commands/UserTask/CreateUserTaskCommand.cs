using MediatR;
using TrialsSystem.UserTaskService.Infrastructure.Models.UserTaskDTOs;

namespace TrialsSystem.UserTaskService.Api.Application.Commands.UserTask
{
    public class CreateUserTaskCommand : IRequest<CreateUserTaskResponse>
    {
        public CreateUserTaskCommand(string email,
            string name,
            string surname,
            string cityId,
            DateTime birthDate,
            decimal? weight,
            decimal? height,
            string genderId)
        {
            Email = email;
            Name = name;
            Surname = surname;
            CityId = cityId;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;
            GenderId = genderId;
        }

        public string Email { get; }

        public string Name { get; }

        public string Surname { get; }

        public string CityId { get; }

        public DateTime BirthDate { get; }

        public decimal? Weight { get; }

        public decimal? Height { get; }

        public string GenderId { get; }


    }
}
