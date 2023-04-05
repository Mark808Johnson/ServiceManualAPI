using EtteplanMORE.ServiceManual.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EtteplanMORE.ServiceManual.Infrastructure.Data.SeedData
{
    public static class EntityBuilderExtension
    {
        public static void Seed(this EntityTypeBuilder<FactoryDevice> entityTypeBuilder)
        {
            var seedData = SeedDataService.ReadCsvData();

            entityTypeBuilder.HasData(
                seedData.Select(x => new FactoryDevice
                {
                    Id = x.Id,
                    Name = x.Name,
                    Year = x.Year,
                    Type = x.Type,
                }
                ));
        }
    }
}
