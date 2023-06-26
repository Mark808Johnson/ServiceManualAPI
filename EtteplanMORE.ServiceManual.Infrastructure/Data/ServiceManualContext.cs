using EtteplanMORE.ServiceManual.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EtteplanMORE.ServiceManual.ApplicationCore.Data
{
    public class ServiceManualContext : DbContext
    {
        public ServiceManualContext(DbContextOptions<ServiceManualContext> options) 
            : base(options) 
        {
        }
        
        public DbSet<FactoryDevice> FactoryDevices { get; set; }
        public DbSet<MaintenanceTask> MaintenanceTasks { get; set; }

                
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MaintenanceTaskEntityConfiguration());
            modelBuilder.ApplyConfiguration(new FactoryDeviceEntityConfiguration());
        }
    }
}