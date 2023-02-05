using System.ComponentModel.DataAnnotations.Schema;

namespace TrialsSystem.UsersService.Domain.AggregatesModel.DeviceAggregate
{
    public class Device
    {
        public Device(Guid id, string serialNumber, string model, Guid typeId, string firmwareVersion)
        {
            Id = id;
            SerialNumber = serialNumber;
            Model = model;
            TypeId = typeId;
            FirmwareVersion = firmwareVersion;
        }

        public Guid Id { get; set; }

        public string SerialNumber { get; set; }

        public string Model { get; set; }

        private Guid TypeId { get; set; }

        [ForeignKey("TypeId")]
        public DeviceType Type { get; set; }

        public string FirmwareVersion { get; set; }
    }
}