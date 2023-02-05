using AutoMapper;
using TrialsSystem.UsersService.Domain.AggregatesModel.DeviceAggregate;
using TrialsSystem.UsersService.Domain.AggregatesModel.UserAggregate;
using TrialsSystem.UsersService.Infrastructure.Models.DeviceDTOs;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Infrastructure.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, GetUsersResponse>()
                .ForMember(dest => dest.CityName,
                    opt =>
                        opt.MapFrom(x => x.City.Name))
                .ForMember(dest => dest.GenderName,
                    opt =>
                        opt.MapFrom(x => x.Gender.Name));

            CreateMap<Device, GetDevicesResponse>()
                .ForMember(dest => dest.TypeName,
                    opt =>
                        opt.MapFrom(x => x.Type.Name));

            CreateMap<Device, CreateDeviceResponse>()
                .ForMember(dest => dest.TypeName,
                    opt =>
                        opt.MapFrom(x => x.Type.Name))
                .ForMember(dest => dest.TypeId,
                    opt => opt.Ignore());
        }
    }
}