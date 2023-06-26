using AutoMapper;
using EtteplanMORE.ServiceManual.ApplicationCore.Entities;

namespace EtteplanMORE.ServiceManual.ApplicationCore.MappingProfiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<FactoryDevice, FactoryDeviceDto>()
                .ForMember(dest => dest.MaintenanceTasks, opt => opt.MapFrom(src => src.MaintenanceTasks));

            CreateMap<MaintenanceTask, FactoryDeviceMaintenanceTasksDto>()
                .ForMember(dest => dest.SeverityLevel, opt => opt.MapFrom(src => src.SeverityLevel.ToString()))
                .ForMember(dest => dest.CurrentStatus, opt => opt.MapFrom(src => src.CurrentStatus.ToString()));

            CreateMap<FactoryDeviceMaintenanceTasksDto, MaintenanceTask>()
                .ForMember(dest => dest.SeverityLevel, opt => opt.MapFrom(src => Enum.Parse<Severity>(src.SeverityLevel)))
                .ForMember(dest => dest.CurrentStatus, opt => opt.MapFrom(src => Enum.Parse<Status>(src.CurrentStatus)));

            CreateMap<MaintenanceTask, MaintenanceTaskDto>()
                .ForMember(dest => dest.SeverityLevel, opt => opt.MapFrom(src => src.SeverityLevel.ToString()))
                .ForMember(dest => dest.CurrentStatus, opt => opt.MapFrom(src => src.CurrentStatus.ToString()))
                .ForMember(dest => dest.TargetDeviceName, opt => opt.MapFrom(src => src.TargetDevice.Name))
                .ForMember(dest => dest.TargetDeviceId, opt => opt.MapFrom(src => src.TargetDevice.Id));
        }
    }
}
