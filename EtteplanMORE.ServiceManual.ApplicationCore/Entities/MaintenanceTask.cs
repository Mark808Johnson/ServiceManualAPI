using System;

namespace EtteplanMORE.ServiceManual.ApplicationCore.Entities
{
    public class MaintenanceTask
    {
        public int Id { get; set; }
        public DateTimeOffset TimeRegistered { get; set; }
        public string Description { get; set; }
        public Severity SeverityLevel { get; set; }
        public Status CurrentStatus { get; set; }
        
        //Navigation properties
        public int TargetDeviceId { get; set; }
        public FactoryDevice TargetDevice { get; set; }

    }

    public enum Severity
    {
        Critical = 1,
        Important = 2,
        Unimportant = 3
    }

    public enum Status
    {
        Open = 0,
        Closed = 1
    }
}
