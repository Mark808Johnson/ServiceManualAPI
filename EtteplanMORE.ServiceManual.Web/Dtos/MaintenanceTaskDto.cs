namespace EtteplanMORE.ServiceManual.ApplicationCore.Entities
{
    public class MaintenanceTaskDto
    {
        public int Id { get; set; }
        public DateTimeOffset TimeRegistered { get; set; }
        public string Description { get; set; }
        public string SeverityLevel { get; set; }
        public string CurrentStatus { get; set; }
        public int TargetDeviceId { get; set; }
    }
}
