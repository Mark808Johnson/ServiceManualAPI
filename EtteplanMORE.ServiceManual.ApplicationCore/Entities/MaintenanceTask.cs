using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        Critical = 2,
        Important = 1,
        Unimportant = 0
    }

    public enum Status
    {
        Open = 1,
        Closed = 2
    }
}
