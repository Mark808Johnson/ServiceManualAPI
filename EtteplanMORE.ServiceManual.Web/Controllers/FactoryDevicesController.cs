using AutoMapper;
using EtteplanMORE.ServiceManual.ApplicationCore.Entities;
using EtteplanMORE.ServiceManual.ApplicationCore.Exceptions;
using EtteplanMORE.ServiceManual.ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EtteplanMORE.ServiceManual.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FactoryDevicesController : ControllerBase
    {
        private readonly IFactoryDeviceService _factoryDeviceService;
        private readonly IMapper _mapper;
        private readonly ILogger<FactoryDevicesController> _logger;

        public FactoryDevicesController(
            IFactoryDeviceService factoryDeviceService,
            IMapper mapper,
            ILogger<FactoryDevicesController> logger)
        {
            _factoryDeviceService = factoryDeviceService;
            _mapper = mapper;
            _logger = logger;
        }

        /// <summary>
        ///     HTTP GET: api/factorydevices    
        /// </summary>
        /// <returns>
        ///     Data of all factory devices in database 
        ///     "404 NotFound" error response if no factory devices found in database.
        ///     "500 InternalServer" error response for all other exceptions.
        /// </returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FactoryDeviceDto>>> GetAllDevices()
        {
            try
            {

                var devices = await _factoryDeviceService.GetAllFactoryDevices();

                var result = devices.Select(device => _mapper.Map<FactoryDeviceDto>(device));

                //var result = devices.Select(device => new FactoryDeviceDto
                //{
                //    Id = device.Id,
                //    Name = device.Name,
                //    Year = device.Year,
                //    Type = device.Type,
                //    MaintenanceTasks = device.MaintenanceTasks.Select(task => new FactoryDeviceMaintenanceTasksDto
                //    {
                //        Id = task.Id,
                //        TimeRegistered = task.TimeRegistered,
                //        Description = task.Description,
                //        SeverityLevel = task.SeverityLevel.ToString(),
                //        CurrentStatus = task.CurrentStatus.ToString()
                //    }).ToList()
                //});

                return Ok(result);
            }

            catch (DeviceNotFoundException ex)
            {
                _logger.LogError(ex, "No factory devices found in database");

                return NotFound("No factory devices found in database");
            }

            catch (Exception ex)
            {
                _logger.LogError(ex, "An unexpected error occurred while adding a new maintenance task.");

                return StatusCode(StatusCodes.Status500InternalServerError, "An unexpected error occurred while processing the request.");

            }
        }

        /// <summary>
        ///     HTTP GET: api/factorydevices/1
        /// </summary>
        /// <param name=deviceId></param>
        /// <returns>
        ///     Data of factory device by given Id. Returns "404 Not Found" response if no such device located in DB. 
        /// </returns>
        [HttpGet("{deviceId}")]
        public async Task<IActionResult> GetDeviceById(int deviceId)
        {
            try
            {
                var device = await _factoryDeviceService.GetFactoryDeviceById(deviceId);

                var result = _mapper.Map<FactoryDeviceDto>(device);

                //var result = new FactoryDeviceDto
                //{
                //    Id = device.Id,
                //    Name = device.Name,
                //    Year = device.Year,
                //    Type = device.Type,
                //    MaintenanceTasks = device.MaintenanceTasks.Select(task => new FactoryDeviceMaintenanceTasksDto
                //    {
                //        Id = task.Id,
                //        TimeRegistered = task.TimeRegistered,
                //        Description = task.Description,
                //        SeverityLevel = task.SeverityLevel.ToString(),
                //        CurrentStatus = task.CurrentStatus.ToString() 
                //    }).ToList()
                //};

                return Ok(result);
            }

            catch (ArgumentException ex)
            {
                _logger.LogError(ex, "An argument exception occurred while getting factory device.");

                return NotFound("No factory device with given Id found in Database");
            }

            catch (Exception ex)
            {
                _logger.LogError(ex, "An unexpected error occurred while getting factory device data.");

                return StatusCode(StatusCodes.Status500InternalServerError, "An unexpected error occurred while processing the request.");
            }
        }
    }
}