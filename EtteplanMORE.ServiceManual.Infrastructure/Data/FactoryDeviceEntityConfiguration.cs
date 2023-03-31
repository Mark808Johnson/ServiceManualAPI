using EtteplanMORE.ServiceManual.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EtteplanMORE.ServiceManual.Infrastructure.Data
{
    public class FactoryDeviceEntityConfiguration : IEntityTypeConfiguration<FactoryDevice>
    {
        public void Configure(EntityTypeBuilder<FactoryDevice> builder)
        {
            builder.ToTable("FactoryDevices");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Year).IsRequired();
            builder.Property(x => x.Type).IsRequired();

            //Configure one-to-many relationship with MaintenanceTask 
            //builder
            //    .HasMany(x => x.MaintenanceTasks)
            //    .WithOne(y => y.TargetDevice);
                //.HasForeignKey(x => x.Id);
        }
    }
}