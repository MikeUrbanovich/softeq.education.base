namespace TrialsSystem.UsersService.Infrastructure.Models.DeviceDTOs
{
    public class CreateDeviceResponse : CreateDeviceRequest
    {
        public Guid Id { get; set; }

        public string TypeName { get; set; }
    }
}