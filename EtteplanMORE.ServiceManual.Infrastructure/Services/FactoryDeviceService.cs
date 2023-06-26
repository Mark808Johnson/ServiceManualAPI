using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;
using EtteplanMORE.ServiceManual.ApplicationCore.Entities;
using EtteplanMORE.ServiceManual.ApplicationCore.Data;
using EtteplanMORE.ServiceManual.ApplicationCore.Exceptions;
using EtteplanMORE.ServiceManual.ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EtteplanMORE.ServiceManual.ApplicationCore.Services
{
    public class FactoryDeviceService : IFactoryDeviceService
    {
        private readonly ServiceManualContext _dbContext;

        public FactoryDeviceService(ServiceManualContext dbContext) 
        
        {
            _dbContext = dbContext;
        }


        public async Task<IEnumerable<FactoryDevice>> GetAllFactoryDevices()
        {
            var factoryDevices = await _dbContext.FactoryDevices
                .Include(x => x.MaintenanceTasks)
                .Select(x => x)
                .ToListAsync();

            if (factoryDevices.Count == 0)
            {
                throw new DeviceNotFoundException("No factory device discovered in database");
            }

            return factoryDevices;
        }

        public async Task<FactoryDevice> GetFactoryDeviceById(int id)
        {
            var factoryDevice = await _dbContext.FactoryDevices
                .Include(x => x.MaintenanceTasks)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (factoryDevice == null) 
            {
                throw new ArgumentException("No factory device discovered with given id");
            }

            return factoryDevice;
        }
    }
}