using AutoMapper;
using CloudBar.BusinessLogic.Dto;
using CloudBar.Domain.General;
using CloudBar.Domain.Security;

namespace CloudBar.BusinessLogic.Profiles
{
    public class CloudBarProfile : Profile
    {
        public CloudBarProfile()
        {
            CreateMap<Role, RoleDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Place, PlaceDto>().ReverseMap();
            CreateMap<Person, PersonDto>().ReverseMap();
            CreateMap<Parameter, ParameterDto>().ReverseMap();
        }
    }
}
