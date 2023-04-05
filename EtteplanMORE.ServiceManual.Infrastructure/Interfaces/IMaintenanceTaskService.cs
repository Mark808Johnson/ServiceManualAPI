using EtteplanMORE.ServiceManual.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtteplanMORE.ServiceManual.Infrastructure.Interfaces
{
    public interface IMaintenanceTaskService
    {
        Task<MaintenanceTask> AddNewTask(string description, Severity severityLevel, Status currentStatus, int deviceId);
        Task<IEnumerable<MaintenanceTask>> GetAllMaintenanceTasks();
        Task<IEnumerable<MaintenanceTask>> GetMaintenanceTasksByDevice(int factoryDeviceId);
        Task<MaintenanceTask> UpdateMaintenanceTask (int taskId, string? description, Severity? severityLevel, Status? currentStatus);
        Task DeleteMaintenanceTask(int taskId);
    }
}
