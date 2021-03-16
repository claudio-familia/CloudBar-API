using CloudBar.BusinessLogic.Services.Contracts;
using CloudBar.Domain.General;
using Microsoft.AspNetCore.Mvc;

namespace CloudBar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaceController : BaseController<Place>
    {
        public PlaceController(IBaseService<Place> baseService) : base(baseService)
        {
        }
    }
}
