using EtteplanMORE.ServiceManual.ApplicationCore.Entities;
using EtteplanMORE.ServiceManual.ApplicationCore.Data;
using EtteplanMORE.ServiceManual.ApplicationCore.Exceptions;
using EtteplanMORE.ServiceManual.ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EtteplanMORE.ServiceManual.ApplicationCore.Services
{
    public class MaintenanceTaskService : IMaintenanceTaskService
    {
        private readonly ServiceManualContext _dbContext;

        public MaintenanceTaskService(ServiceManualContext dbContext)

        {
            _dbContext = dbContext;
        }

        public async Task<MaintenanceTask> AddNewTask(string description, Severity severityLevel, Status currentStatus, int targetDeviceId)
        {
            var device = await _dbContext.FactoryDevices
                .FirstOrDefaultAsync(x => x.Id == targetDeviceId);

            if (device == null)
            {
                throw new ArgumentException("No factory device with given Id found in Database. Maintenance task cannot be added without targetting existing device", nameof(targetDeviceId));
            }

            var newTask = new MaintenanceTask()
            {
                TimeRegistered = DateTime.UtcNow,
                Description = description,
                SeverityLevel = severityLevel,
                CurrentStatus = currentStatus,
                TargetDeviceId = targetDeviceId,
                TargetDevice = device
            };

            await _dbContext.MaintenanceTasks.AddAsync(newTask);
            await _dbContext.SaveChangesAsync();

            return (newTask);
        }

        public async Task<IEnumerable<MaintenanceTask>> GetAllMaintenanceTasks()
        {
            var maintenanceTasks = await _dbContext.MaintenanceTasks
                .Include(x => x.TargetDevice)
                .Select(x => x)
                .OrderBy(x => x.SeverityLevel).ThenBy(x => x.TimeRegistered)
                .ToListAsync();

            if (maintenanceTasks.Count == 0)
            {
                throw new TaskNotFoundException("No maintenance tasks discovered in database");
            }
                
            return maintenanceTasks;
        }

        public async Task<IEnumerable<MaintenanceTask>> GetMaintenanceTasksByDevice(int factoryDeviceId)
        {
            var factoryDevice = await _dbContext.FactoryDevices
                .FirstOrDefaultAsync(x => x.Id == factoryDeviceId);

            if (factoryDevice == null)
            {
                throw new ArgumentException("No factory device with given Id found in Database", nameof(factoryDeviceId));
            }

            var maintenanceTasksbyDevice = await _dbContext.MaintenanceTasks
                .Where(x => x.TargetDeviceId == factoryDevice.Id)
                .OrderBy(x => x.SeverityLevel).ThenBy(x => x.TimeRegistered)
                .ToListAsync();

            if (maintenanceTasksbyDevice.Count == 0)
            {
                throw new TaskNotFoundException("No maintenance tasks discovered for given factory device");
            }    
                
            return maintenanceTasksbyDevice;
        }

        public async Task<MaintenanceTask> UpdateMaintenanceTask(int taskId, string? description, Severity? severityLevel, Status? currentStatus)
        {
            var taskToUpdate = await _dbContext.MaintenanceTasks
                .Include(x => x.TargetDevice)
                .FirstOrDefaultAsync(x => x.Id == taskId);

            if (taskToUpdate == null)
            {
                throw new ArgumentException("No maintenance task with given Id found in Database", nameof(taskId));
            }

            if (description != null)
            {
                taskToUpdate.Description = description;
            }

            if (severityLevel != null) 
            {
                taskToUpdate.SeverityLevel = (Severity)severityLevel;
            }

            if (currentStatus != null)
            {
                taskToUpdate.CurrentStatus = (Status)currentStatus;
            }

            //If intention is to reset time registered, following line can be used
            //taskToUpdate.TimeRegistered = DateTimeOffset.UtcNow;

            _dbContext.Update(taskToUpdate);
            await _dbContext.SaveChangesAsync();

            return taskToUpdate;
        }

        public async Task DeleteMaintenanceTask(int taskId)
        {
            var taskToDelete = await _dbContext.MaintenanceTasks.FirstOrDefaultAsync(x => x.Id == taskId);

            if (taskToDelete == null) 
            {
                throw new ArgumentException("No maintenance task with given Id found in Database", nameof(taskId));
            }

            _dbContext.Remove(taskToDelete);
            await _dbContext.SaveChangesAsync();
        }
    }
}
