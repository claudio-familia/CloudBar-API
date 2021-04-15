using CloudBar.BusinessLogic.Services.Contracts;
using CloudBar.Domain.Security;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CloudBar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : BaseController<User>
    {
        private readonly IBaseService<User> _baseService;
        public UsersController(IBaseService<User> baseService) : base(baseService)
        {
            _baseService = baseService;
        }

        [HttpGet]
        public override IActionResult Get(string sortExpression)
        {
            var response = _baseService.GetAll(user => user,
                                                     user => user.Active.Value);

            return Ok(response);
        }
    }
}
