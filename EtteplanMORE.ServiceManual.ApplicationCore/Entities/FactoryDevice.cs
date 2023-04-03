using System;
using System.Collections;
using System.Collections.Generic;

namespace EtteplanMORE.ServiceManual.ApplicationCore.Entities
{
    public class FactoryDevice
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
        public ICollection<MaintenanceTask> MaintenanceTasks { get; set; }
    }
}