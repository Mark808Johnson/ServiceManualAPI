using EtteplanMORE.ServiceManual.ApplicationCore.Entities;
using System.ComponentModel.DataAnnotations;

namespace EtteplanMORE.ServiceManual.Web.Controllers.Requests
{
    public class AddNewMaintenanceTaskRequest
    {
        [Required(ErrorMessage = "The description field is required")]
        public string Description { get; set; }
        [Range(1, 3, ErrorMessage = "Severity must be 1 (critical), 2 (important) or 3 (unimportant")]
        public Severity Severity { get; set; }
        [Range(0, 1, ErrorMessage = "Status must be between 0 (open) and 1 (closed)")]
        public Status Status { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "TargetDeviceId has to be an integer")]
        public int TargetDeviceId { get; set; }
    }
}