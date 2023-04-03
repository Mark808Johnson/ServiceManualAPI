using EtteplanMORE.ServiceManual.ApplicationCore.Entities;

namespace EtteplanMORE.ServiceManual.Web.Controllers
{
    public class UpdateMaintenanceTaskRequest
    {
        public string Description { get; set; }
        public Severity Severitylevel { get; set; }
        public Status CurrentStatus { get; set; }
    }
}