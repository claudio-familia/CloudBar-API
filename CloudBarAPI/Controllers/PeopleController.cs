using CloudBar.BusinessLogic.Services.Contracts;
using CloudBar.Domain.General;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CloudBar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PeopleController : BaseController<Person>
    {
        public PeopleController(IBaseService<Person> baseService) : base(baseService)
        {
        }
    }
}
