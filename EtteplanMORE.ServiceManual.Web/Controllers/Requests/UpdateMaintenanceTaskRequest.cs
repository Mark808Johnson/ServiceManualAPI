using EtteplanMORE.ServiceManual.ApplicationCore.Entities;

namespace EtteplanMORE.ServiceManual.Web.Controllers.Requests
{
    public class UpdateMaintenanceTaskRequest
    {
        public string? Description { get; set; }
        public Severity? Severitylevel { get; set; }
        public Status? CurrentStatus { get; set; }
    }
}