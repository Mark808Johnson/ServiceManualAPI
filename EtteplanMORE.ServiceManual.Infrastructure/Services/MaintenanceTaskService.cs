using EtteplanMORE.ServiceManual.ApplicationCore.Entities;
using EtteplanMORE.ServiceManual.Infrastructure.Data;
using EtteplanMORE.ServiceManual.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtteplanMORE.ServiceManual.Infrastructure.Services
{
    public class MaintenanceTaskService : IMaintenanceTaskService
    {
        private readonly ServiceManualContext _dbContext;

        public MaintenanceTaskService(ServiceManualContext dbContext)

        {
            _dbContext = dbContext;
        }

        public async Task<int> AddNewTask(string description, Severity severityLevel, Status currentStatus, int targetDeviceId)
        {
            var device = await _dbContext.FactoryDevices
                .FirstOrDefaultAsync(x => x.Id == targetDeviceId);

            if (device == null)
            {
                throw new Exception("No device found with provided Id. Maintenance task cannot be added without targetting existing device");
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

            return newTask.Id;
        }

        public async Task<IEnumerable<MaintenanceTask>> GetAllMaintenanceTasks()
        {
            var maintenanceTasks = await _dbContext.MaintenanceTasks
                .Select(x => x)
                .ToListAsync();

            return maintenanceTasks;
        }

        public async Task<IEnumerable<MaintenanceTask>> GetMaintenanceTasksByDevice(int factoryDeviceId)
        {
            var factoryDevice = await _dbContext.FactoryDevices
                .FirstOrDefaultAsync(x => x.Id == factoryDeviceId);

            if (factoryDevice == null)
            {
                throw new Exception("No factory device discovered with provided Id");
            }

            var maintenanceTasksbyDevice = await _dbContext.MaintenanceTasks
                .Where(x => x.TargetDeviceId == factoryDevice.Id)
                .ToListAsync();
                
            return maintenanceTasksbyDevice;
        }

        public async Task ModifyMaintenanceTask(int taskId, string? description, Severity? severityLevel, Status? currentStatus)
        {
            //var taskToModify = await _dbContext.MaintenanceTasks
            //    .FirstOrDefaultAsync(x => x.Id == taskId);

            //if (taskToModify == null)
            //{
            //    throw new Exception("No task discovered with provided Id");
            //}

            //if (description != null) 
            //{
            //    taskToModify.Description = description;
            //}
        }

        public async Task DeleteMaintenanceTask(int taskId)
        {
            var taskToDelete = await _dbContext.MaintenanceTasks.FirstOrDefaultAsync(x => x.Id == taskId);

            if (taskToDelete == null) 
            {
                throw new Exception("No task discovered with provided Id");
            }

            _dbContext.Remove(taskToDelete);
            await _dbContext.SaveChangesAsync();
        }

    }
}
