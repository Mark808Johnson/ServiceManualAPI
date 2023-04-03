using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AutoMapper;
using EtteplanMORE.ServiceManual.ApplicationCore.Entities;
using EtteplanMORE.ServiceManual.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EtteplanMORE.ServiceManual.Web.Controllers
{
    [Route("api/[controller]")]
    public class FactoryDevicesController : Controller
    {
        private readonly IFactoryDeviceService _factoryDeviceService;
        private IMapper _mapper;

        public FactoryDevicesController(
            IFactoryDeviceService factoryDeviceService,
            IMapper mapper)

        {
            _factoryDeviceService = factoryDeviceService;
            _mapper = mapper;
        }

        // <summary>
        //     HTTP GET: api/factorydevices/
        // </summary>
        [HttpGet]
        public async Task<IEnumerable<FactoryDeviceDto>> GetAllDevices()
        {
            var devices = await _factoryDeviceService.GetAllFactoryDevices();

            var result = devices.Select(device => new FactoryDeviceDto
            {
                Id = device.Id,
                Name = device.Name,
                Year = device.Year,
                Type = device.Type,
                MaintenanceTasksDtos = device.MaintenanceTasks.Select(task => new FactoryDeviceMaintenanceTasksDto
                {
                    Id = task.Id,
                    TimeRegistered = task.TimeRegistered,
                    Description = task.Description,
                    SeverityLevel = task.SeverityLevel.ToString(),
                    CurrentStatus = task.CurrentStatus.ToString()
                }).ToList()
            });

            return result;
        }

        /// <summary>
        ///     HTTP GET: api/factorydevices/1
        /// </summary>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDeviceById(int id)
        {
            try
            {
                var device = await _factoryDeviceService.GetFactoryDeviceById(id);

                var result = new FactoryDeviceDto
                {
                    Id = device.Id,
                    Name = device.Name,
                    Year = device.Year,
                    Type = device.Type,
                    MaintenanceTasksDtos = device.MaintenanceTasks.Select(task => new FactoryDeviceMaintenanceTasksDto
                    {
                        Id = task.Id,
                        TimeRegistered = task.TimeRegistered,
                        Description = task.Description,
                        SeverityLevel = task.SeverityLevel.ToString(),
                        CurrentStatus = task.CurrentStatus.ToString() 
                    }).ToList()
                };

                return Ok(result);
            }

            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}