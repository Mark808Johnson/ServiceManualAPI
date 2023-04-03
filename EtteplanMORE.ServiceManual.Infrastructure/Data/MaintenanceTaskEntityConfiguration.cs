using EtteplanMORE.ServiceManual.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EtteplanMORE.ServiceManual.Infrastructure.Data
{
    public class MaintenanceTaskEntityConfiguration : IEntityTypeConfiguration<MaintenanceTask>
    {
        public void Configure(EntityTypeBuilder<MaintenanceTask> builder)
        {
            builder.ToTable("Maintenance Tasks");

            builder
                .HasOne<FactoryDevice>(x => x.TargetDevice)
                .WithMany(y => y.MaintenanceTasks)
                .HasForeignKey(z => z.TargetDeviceId);
        }
    }
}