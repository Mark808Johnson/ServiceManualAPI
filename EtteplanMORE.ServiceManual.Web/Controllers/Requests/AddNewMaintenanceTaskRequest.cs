using EtteplanMORE.ServiceManual.ApplicationCore.Entities;
using System.ComponentModel.DataAnnotations;

namespace EtteplanMORE.ServiceManual.Web.Controllers.Requests
{
    public class AddNewMaintenanceTaskRequest
    {
        [Required]
        public string Description { get; set; }
        [Required]
        public Severity Severity { get; set; }
        [Required]
        public Status Status { get; set; }
        [Required]
        public int TargetDeviceId { get; set; }
    }
}