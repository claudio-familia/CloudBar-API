using CloudBar.BusinessLogic.Services.Contracts;
using CloudBar.Domain.General;
using Microsoft.AspNetCore.Mvc;

namespace CloudBar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParameterController : BaseController<Parameter>
    {
        public ParameterController(IBaseService<Parameter> baseService) : base(baseService)
        {
        }
    }
}
