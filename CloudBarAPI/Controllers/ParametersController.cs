using CloudBar.BusinessLogic.Services.Contracts;
using CloudBar.Domain.General;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CloudBar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ParametersController : BaseController<Parameter>
    {
        public ParametersController(IBaseService<Parameter> baseService) : base(baseService)
        {
        }
    }
}
