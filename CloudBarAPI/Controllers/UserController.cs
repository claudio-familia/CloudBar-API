using CloudBar.BusinessLogic.Services.Contracts;
using CloudBar.Domain.Security;
using Microsoft.AspNetCore.Mvc;

namespace CloudBar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseController<User>
    {
        public UserController(IBaseService<User> baseService) : base(baseService)
        {
        }
    }
}
