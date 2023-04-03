namespace EtteplanMORE.ServiceManual.ApplicationCore.Entities
{
    public class FactoryDeviceDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Year { get; set; }
        public string? Type { get; set; }

        public IEnumerable<FactoryDeviceMaintenanceTasksDto> MaintenanceTasksDtos { get; set; }
    }

    public class FactoryDeviceMaintenanceTasksDto
    {
        public int Id { get; set; }
        public DateTimeOffset TimeRegistered { get; set; }
        public string Description { get; set; }
        public string SeverityLevel { get; set; }
        public string CurrentStatus { get; set; }
    }

    //public enum SeverityDto
    //{
    //    Critical = 2,
    //    Important = 1,
    //    Unimportant = 0
    //}

    //public enum StatusDto
    //{
    //    Open = 1,
    //    Closed = 2
    //}
}