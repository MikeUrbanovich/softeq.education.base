namespace TrialsSystem.UserTaskService.Infrastructure.Models.UserTaskDTOs
{
    public class UpdateUserTaskResponse
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime BirthDate { get; set; }

        public decimal? Weight { get; set; }

        public decimal? Height { get; set; }

        public string CityId { get; set; }
    }
}
