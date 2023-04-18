namespace EtteplanMORE.ServiceManual.ApplicationCore.Entities
{
    public class FactoryDeviceDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Year { get; set; }
        public string? Type { get; set; }
        public IEnumerable<FactoryDeviceMaintenanceTasksDto> MaintenanceTasks { get; set; }
    }

    public class FactoryDeviceMaintenanceTasksDto
    {
        public int Id { get; set; }
        public DateTimeOffset TimeRegistered { get; set; }
        public string Description { get; set; }
        public string SeverityLevel { get; set; }
        public string CurrentStatus { get; set; }
    }
}