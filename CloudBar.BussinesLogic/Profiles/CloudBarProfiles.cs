using AutoMapper;
using CloudBar.BusinessLogic.Dto;
using CloudBar.Domain.Security;

namespace CloudBar.BusinessLogic.Profiles
{
    public class CloudBarProfile : Profile
    {
        public CloudBarProfile()
        {
            CreateMap<Role, RoleDto>().ReverseMap();
        }
    }
}
