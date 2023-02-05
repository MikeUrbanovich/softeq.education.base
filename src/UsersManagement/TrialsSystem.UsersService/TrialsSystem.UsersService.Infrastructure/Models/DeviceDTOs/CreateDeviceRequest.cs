namespace TrialsSystem.UsersService.Infrastructure.Models.DeviceDTOs
{
    public class CreateDeviceRequest
    {
        public string SerialNumber { get; set; }

        public string Model { get; set; }

        public Guid TypeId { get; set; }

        public string FirmwareVersion { get; set; }
    }
}