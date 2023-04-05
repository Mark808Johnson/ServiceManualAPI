using AutoMapper;
using EtteplanMORE.ServiceManual.ApplicationCore.Entities;
using EtteplanMORE.ServiceManual.Infrastructure.Interfaces;
using EtteplanMORE.ServiceManual.Infrastructure.Services;
using EtteplanMORE.ServiceManual.Web.Controllers.Requests;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Security.Cryptography.X509Certificates;

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

        /// <summary>
        ///    HTTP POST: api/maintenancetasks/
        /// </summary>
        /// <param name="request"></param>
        /// <returns>
        ///     Data about new maintenance task and "201 Created" status response. 
        ///     "400 Bad Request" status response for errors.
        /// </returns>
        [HttpPost]
        public async Task<IActionResult> AddNewMaintenanceTask([FromQuery] AddNewMaintenanceTaskRequest request)
        {
            try
            {
                var newTask = await _maintenanceTaskService.AddNewTask(request.Description, request.Severity, request.Status, request.TargetDeviceId);

                var result = new MaintenanceTaskDto
                {
                    Id = newTask.Id,
                    TimeRegistered = newTask.TimeRegistered,
                    Description = newTask.Description,
                    SeverityLevel = newTask.SeverityLevel.ToString(),
                    CurrentStatus = newTask.CurrentStatus.ToString(),
                    TargetDeviceName = newTask.TargetDevice.Name,
                    TargetDeviceId = newTask.TargetDeviceId
                };

                return CreatedAtAction(nameof(AddNewMaintenanceTask), result);
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        ///     HTTP GET: api/maintenancetasks/
        /// </summary>
        /// <returns>
        ///     List of all maintenance tasks in database.
        /// </returns>
        [HttpGet]
        public async Task<IEnumerable<MaintenanceTaskDto>> GetAllMaintenanceTasks()
        {
            var allTasks = await _maintenanceTaskService.GetAllMaintenanceTasks();

            var result = allTasks.Select(task => new MaintenanceTaskDto
            {
                Id = task.Id,
                TimeRegistered = task.TimeRegistered,
                Description = task.Description,
                SeverityLevel = task.SeverityLevel.ToString(),
                CurrentStatus = task.CurrentStatus.ToString(),
                TargetDeviceName = task.TargetDevice.Name,
                TargetDeviceId = task.TargetDeviceId,
            });

            return result;
        }


        /// <summary>
        ///     HTTP GET: api/maintenancetasks/{deviceId}
        /// </summary>
        /// <returns>
        ///     List of all maintenance tasks targetting given device (by deviceId). 
        ///     Returns "404 Not Found" status response if device not found in DB.
        /// </returns>
        [HttpGet("{deviceId}")]
        public async Task<ActionResult<IEnumerable<MaintenanceTaskDto>>> GetMaintenanceTasksByDevice([FromRoute] int deviceId)
        {
            try
            {
                var tasks = await _maintenanceTaskService.GetMaintenanceTasksByDevice(deviceId);

                var result = tasks.Select(task => new MaintenanceTaskDto
                {
                    Id = task.Id,
                    TimeRegistered = task.TimeRegistered,
                    Description = task.Description,
                    SeverityLevel = task.SeverityLevel.ToString(),
                    CurrentStatus = task.CurrentStatus.ToString(),
                    TargetDeviceName = task.TargetDevice.Name,
                    TargetDeviceId = task.TargetDeviceId,
                });

                return Ok(result);
            }

            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        /// <summary>
        ///     HTTP PUT: api/maintenancetasks/{taskId}
        /// </summary>
        /// <returns>
        ///     Updates maintenance task data (by taskId) according to provided optional request data, and returns task data. 
        ///     Returns "404 Not Found" status response if task not found in DB.
        /// </returns>
        [HttpPut("{taskId}")]
        public async Task<IActionResult> UpdateMaintenanceTask([FromRoute] int taskId, [FromQuery] UpdateMaintenanceTaskRequest request)
        {
            try
            {
                var updatedTask = await _maintenanceTaskService.UpdateMaintenanceTask(taskId, request.Description, request.Severitylevel, request.CurrentStatus);

                var result = new MaintenanceTaskDto
                {
                    Id = updatedTask.Id,
                    TimeRegistered = updatedTask.TimeRegistered,
                    Description = updatedTask.Description,
                    SeverityLevel = updatedTask.SeverityLevel.ToString(),
                    CurrentStatus = updatedTask.CurrentStatus.ToString(),
                    TargetDeviceName = updatedTask.TargetDevice.Name,
                    TargetDeviceId = updatedTask.TargetDeviceId
                };

                return Ok(result);
            }

            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        /// <summary>
        ///     HTTP DELETE: api/maintenancetasks/{taskId}
        /// </summary>
        /// <returns>
        ///     Deletes maintenance task data (by taskId). 
        ///     Returns "404 Not Found" status response if task not found in DB.
        /// </returns>
        [HttpDelete("{taskId}")]
        public async Task<IActionResult> DeleteMaintenanceTask([FromRoute] int taskId)
        {
            try
            {
                await _maintenanceTaskService.DeleteMaintenanceTask(taskId);
                return Ok();
            }

            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}