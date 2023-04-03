using AutoMapper;
using EtteplanMORE.ServiceManual.ApplicationCore.Entities;
using EtteplanMORE.ServiceManual.Infrastructure.Interfaces;
using EtteplanMORE.ServiceManual.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EtteplanMORE.ServiceManual.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaintenanceTasksController : ControllerBase
    {
        private readonly IMaintenanceTaskService _maintenanceTaskService;
        //private IMapper _mapper;

        public MaintenanceTasksController(
            IMaintenanceTaskService maintenanceeTaskService)
            //IMapper mapper)

        {
            _maintenanceTaskService = maintenanceeTaskService;
            //_mapper = mapper;
        }

        // POST: api/<MaintenanceTasksController>
        [HttpPost]
        public async Task<IActionResult> AddNewMaintenance([FromQuery] AddNewMaintenanceTaskRequest request)
        {
            try
            {
                var result = await _maintenanceTaskService.AddNewTask(request.Description, request.Severity, request.Status, request.TargetDeviceId);

                return StatusCode(StatusCodes.Status201Created, result);
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // <summary>
        //     HTTP GET: api/factorydevices/
        // </summary>
        [HttpGet]
        public async Task<IEnumerable<MaintenanceTaskDto>> GetAllMaintenanceTasks()
        {
            var tasks = await _maintenanceTaskService.GetAllMaintenanceTasks();

            var result = tasks.Select(task => new MaintenanceTaskDto
            {
                Id = task.Id,
                TimeRegistered = task.TimeRegistered,
                Description = task.Description,
                SeverityLevel = task.SeverityLevel.ToString(),
                CurrentStatus = task.CurrentStatus.ToString(),
                TargetDeviceId = task.TargetDeviceId,
            });

            return result;
        }


        // GET api/<MaintenanceTasksController>/5
        [HttpGet("{id}")]
        public async Task<IEnumerable<MaintenanceTaskDto>> GetMaintenanceTasksByDevice([FromRoute] int id )
        {
            var tasks = await _maintenanceTaskService.GetMaintenanceTasksByDevice(id);

            var result = tasks.Select(task => new MaintenanceTaskDto
            {
                Id = task.Id,
                TimeRegistered = task.TimeRegistered,
                Description = task.Description,
                SeverityLevel = task.SeverityLevel.ToString(),
                CurrentStatus = task.CurrentStatus.ToString(),
                TargetDeviceId = task.TargetDeviceId,
            });

            return result;
        }

        // PUT api/<MaintenanceTasksController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMaintenanceTask([FromRoute] int id, [FromQuery] UpdateMaintenanceTaskRequest request)
        {
            try
            {
                await _maintenanceTaskService.ModifyMaintenanceTask(id, request.Description, request.Severitylevel, request.CurrentStatus); 
                return Ok();
            }

            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status404NotFound, ex);
            }
        }

        // DELETE api/<MaintenanceTasksController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMaintenanceTask([FromRoute] int id)
        {
            try
            {
                await _maintenanceTaskService.DeleteMaintenanceTask(id);
                return Ok();
            }

            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status404NotFound, ex);
            }
        }
    }
}
