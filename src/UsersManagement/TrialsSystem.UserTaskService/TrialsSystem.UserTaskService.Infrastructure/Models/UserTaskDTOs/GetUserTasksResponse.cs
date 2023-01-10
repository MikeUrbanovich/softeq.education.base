namespace TrialsSystem.UserTaskService.Infrastructure.Models.UserTaskDTOs
{
    public class GetUserTasksResponse
    {
        public string Email { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime BirthDate { get; set; }

        public decimal? Weight { get; set; }

        public decimal? Height { get; set; }
        public string CityName { get; set; }
        public string GenderName { get; set; }

    }
}
