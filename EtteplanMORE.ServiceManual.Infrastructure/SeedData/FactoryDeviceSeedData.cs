using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EtteplanMORE.ServiceManual.Infrastructure.SeedData
{
    public class FactoryDeviceSeedData
    {
        [Name("Id")]
        public int Id { get; set; }
        [Name("Name")]
        public string Name { get; set; }
        [Name("Year")]
        public int Year { get; set; }
        [Name("Type")] 
        public string Type { get; set; }
    }
}
