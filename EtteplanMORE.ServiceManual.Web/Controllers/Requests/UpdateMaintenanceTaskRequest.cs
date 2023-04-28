using EtteplanMORE.ServiceManual.ApplicationCore.Entities;
using System.ComponentModel.DataAnnotations;

namespace EtteplanMORE.ServiceManual.Web.Controllers.Requests
{
    public class UpdateMaintenanceTaskRequest
    {
        public string? Description { get; set; }
        [Range(1, 3, ErrorMessage = "Severity must be 1 (critical), 2 (important) or 3 (unimportant")]
        public Severity? SeverityLevel { get; set; }
        [Range(0, 1, ErrorMessage = "Status must be between 0 (open) and 1 (closed)")]
        public Status? CurrentStatus { get; set; }
    }
}