using AutoMapper;
using CloudBar.BusinessLogic.Dto;
using CloudBar.Domain.Security;

namespace CloudBar.BusinessLogic.Profiles
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<Role, RoleDto>().ReverseMap();
        }
    }
}
