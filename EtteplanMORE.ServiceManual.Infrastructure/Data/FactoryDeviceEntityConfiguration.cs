using EtteplanMORE.ServiceManual.ApplicationCore.Entities;
using EtteplanMORE.ServiceManual.ApplicationCore.Data.SeedData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace EtteplanMORE.ServiceManual.ApplicationCore.Data
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

            builder.Seed();
        }
    }
}