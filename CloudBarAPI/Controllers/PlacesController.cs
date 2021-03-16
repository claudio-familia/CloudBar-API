using CloudBar.BusinessLogic.Services.Contracts;
using CloudBar.Domain.General;
using Microsoft.AspNetCore.Mvc;

namespace CloudBar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlacesController : BaseController<Place>
    {
        public PlacesController(IBaseService<Place> baseService) : base(baseService)
        {
        }
    }
}
