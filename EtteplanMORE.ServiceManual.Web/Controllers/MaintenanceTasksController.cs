using EtteplanMORE.ServiceManual.ApplicationCore.Entities;
using EtteplanMORE.ServiceManual.Infrastructure.Exceptions;
using EtteplanMORE.ServiceManual.Infrastructure.Interfaces;
using EtteplanMORE.ServiceManual.Web.Controllers.Requests;
using Microsoft.AspNetCore.Mvc;


namespace EtteplanMORE.ServiceManual.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaintenanceTasksController : ControllerBase
    {
        private readonly IMaintenanceTaskService _maintenanceTaskService;
        private readonly ILogger<MaintenanceTasksController> _logger;
        
        public MaintenanceTasksController(
            IMaintenanceTaskService maintenanceTaskService,
            ILogger<MaintenanceTasksController> logger
            )
        
        {
            _maintenanceTaskService = maintenanceTaskService;
            _logger = logger;
        }

        /// <summary>
        ///    HTTP POST: api/maintenancetasks/
        /// </summary>
        /// <param name="request"></param>
        /// <returns>
        ///     Data about new maintenance task and "201 Created" status response. 
        ///     "400 BadRequest" error response if request parameters requirements are not met.
        ///     "404 NotFound" error response if factory device by given Id not found in database.
        ///     "500 InternalServer" error response for all other exceptions.
        /// </returns>
        [HttpPost]
        public async Task<IActionResult> AddNewMaintenanceTask([FromBody] AddNewMaintenanceTaskRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

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

            catch (ArgumentException ex)
            {
                _logger.LogError(ex, "An argument exception occurred while adding a new maintenance task.");

                return NotFound("No factory device with given Id found in Database. Maintenance task cannot be added without targetting existing device");
            }

            catch (Exception ex)
            {
                _logger.LogError(ex, "An unexpected error occurred while adding a new maintenance task.");

                return StatusCode(StatusCodes.Status500InternalServerError, "An unexpected error occurred while adding a new maintenance task.");
            }
        }

        /// <summary>
        ///     HTTP GET: api/maintenancetasks/
        /// </summary>
        /// <returns>
        ///     List of all maintenance tasks in database.
        ///     "404 NotFound" error response if no maintenance tasks found in database.
        ///     "500 InternalServer" error response for all other exceptions.
        /// </returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MaintenanceTaskDto>>> GetAllMaintenanceTasks()
        {
            try
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

                return Ok(result);
            }

            catch (TaskNotFoundException ex)
            {
                _logger.LogError(ex, "No maintenance tasks were found in database");

                return NotFound("No maintenance tasks were found in database");
            }

            catch (Exception ex) 
            {
                _logger.LogError(ex, "An unexpected error occurred while getting all maintenance task data.");

                return StatusCode(StatusCodes.Status500InternalServerError, "An unexpected error occurred while getting all maintenance task data.");

            }
        }

        /// <summary>
        ///     HTTP GET: api/maintenancetasks/{deviceId}
        /// </summary>
        /// <returns>
        ///     List of all maintenance tasks targetting given device (by deviceId). 
        ///     "404 NotFound" error response if maintenance device by given Id not found in DB.
        ///     "500 InternalServer" error response for all other exceptions.
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

            catch (ArgumentException ex)
            {
                _logger.LogError(ex, "An argument exception occurred while getting maintenance task.");

                return NotFound("No factory device with given Id found in Database");
            }

            catch (Exception ex)
            {
                _logger.LogError(ex, "An unexpected error occurred while getting maintenance device data.");

                return StatusCode(StatusCodes.Status500InternalServerError, "An unexpected error occurred while getting maintenance device data.");
            }
        }

        /// <summary>
        ///     HTTP PUT: api/maintenancetasks/{taskId}
        /// </summary>
        /// <returns>
        ///     Updates maintenance task data (by taskId) according to provided optional request data, and returns task data. 
        ///     "400 BadRequest" error response if request parameters requirements are not met.
        ///     "404 NotFound" error response if maintenance device by given Id not found in DB.
        ///     "500 InternalServer" error response for all other exceptions.
        /// </returns>
        [HttpPut("{taskId}")]
        public async Task<IActionResult> UpdateMaintenanceTask([FromRoute] int taskId, [FromBody] UpdateMaintenanceTaskRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var updatedTask = await _maintenanceTaskService.UpdateMaintenanceTask(taskId, request.Description, request.SeverityLevel, request.CurrentStatus);

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


            catch (ArgumentException ex)
            {
                _logger.LogError(ex, "An argument exception occurred while updating maintenance task.");

                return NotFound("No maintenance task with given Id found in Database");
            }

            catch (Exception ex)
            {
                _logger.LogError(ex, "An unexpected error occurred while updating maintenance task.");

                return StatusCode(StatusCodes.Status500InternalServerError, "An unexpected error occurred while updating maintenance task.");
            }
        }

        /// <summary>
        ///     HTTP DELETE: api/maintenancetasks/{taskId}
        /// </summary>
        /// <returns>
        ///     Deletes maintenance task data (by taskId). 
        ///     "404 NotFound" error response if maintenance device by given Id not found in DB.
        ///     "500 InternalServer" error response for all other exceptions.
        /// </returns>
        [HttpDelete("{taskId}")]
        public async Task<IActionResult> DeleteMaintenanceTask([FromRoute] int taskId)
        {
            try
            {
                await _maintenanceTaskService.DeleteMaintenanceTask(taskId);
                return Ok();
            }

            catch (ArgumentException ex)
            {
                _logger.LogError(ex, "An argument exception occurred while deleting maintenance task.");

                return NotFound("No maintenance task with given Id found in Database");
            }

            catch (Exception ex)
            {
                _logger.LogError(ex, "An unexpected error occurred while deleting maintenance task.");

                return StatusCode(StatusCodes.Status500InternalServerError, "An unexpected error occurred while deleting maintenance task.");
            }
        }
    }
}