using System.ComponentModel.DataAnnotations.Schema;

namespace TrialsSystem.UsersService.Domain.AggregatesModel.DeviceAggregate
{
    public class Device
    {
        public Device(string serialNumber, string model, string typeId, string firmwareVersion)
        {
            SerialNumber = serialNumber;
            Model = model;
            TypeId = typeId;
            FirmwareVersion = firmwareVersion;
        }

        public string Id { get; set; }

        public string SerialNumber { get; set; }

        public string Model { get; set; }

        private string TypeId { get; set; }

        [ForeignKey("TypeId")]
        public DeviceType Type { get; set; }

        public string FirmwareVersion { get; set; }
    }
}
