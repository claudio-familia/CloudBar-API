using CloudBar.BusinessLogic.Services;
using CloudBar.Domain.Security;

namespace CloudBar.Controllers
{
    public class RoleController : BaseController<Role>
    {
        public RoleController(RoleService baseService) : base(baseService)
        {
        }
    }
}
