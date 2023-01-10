using TrialsSystem.UsersService.Infrastructure.Models.BaseDTO;

namespace TrialsSystem.UsersService.Infrastructure.Models.DeviceDTOs
{
    public class GetDevicesResponse
    {
        public string SerialNumber { get; set; }

        public string Model { get; set; }

        public string FirmwareVersion { get; set; }

        public string TypeName { get; set; }
    }
}
