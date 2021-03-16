using CloudBar.BusinessLogic.Services.Contracts;
using CloudBar.Domain.Security;
using Microsoft.AspNetCore.Mvc;

namespace CloudBar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : BaseController<User>
    {
        public UsersController(IBaseService<User> baseService) : base(baseService)
        {
        }
    }
}
