using MediatR;
using TrialsSystem.UserTaskService.Infrastructure.Models.UserTaskDTOs;

namespace TrialsSystem.UserTaskService.Api.Application.Commands.UserTask
{
    public class UpdateUserTaskCommand : IRequest<UpdateUserTaskResponse>
    {
        public UpdateUserTaskCommand(string id,
            string name,
            string surname,
            string cityId,
            DateTime birthDate,
            decimal? weight,
            decimal? height)
        {
            Id = id;
            Name = name;
            Surname = surname;
            CityId = cityId;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;
        }

        public string Id { get; }

        public string Name { get; }

        public string Surname { get; }

        public string CityId { get; }

        public DateTime BirthDate { get; }

        public decimal? Weight { get; }

        public decimal? Height { get; }

    }
}
