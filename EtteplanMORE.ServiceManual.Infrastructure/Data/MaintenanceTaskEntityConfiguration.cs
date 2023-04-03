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

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.TimeRegistered).IsRequired();
            builder.Property(x => x.Description);
            builder.Property(x => x.SeverityLevel).IsRequired();
            builder.Property(x => x.CurrentStatus).IsRequired();

            builder
                .HasOne<FactoryDevice>(x => x.TargetDevice)
                .WithMany(y => y.MaintenanceTasks)
                .HasForeignKey(z => z.TargetDeviceId);
        }
    }
}