using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtteplanMORE.ServiceManual.ApplicationCore.Data.SeedData
{
    public class SeedDataService
    {
        public static IEnumerable<FactoryDeviceSeedData> ReadCsvData()
        {
            string path = @"../seeddata.csv";

            var streamReader = new StreamReader(path);
            var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture);

            var result = csvReader.GetRecords<FactoryDeviceSeedData>().ToList();

            streamReader.Close();

            return result;
        }
    }
}


