using CloudBar.BusinessLogic.Services.Contracts;
using CloudBar.Domain.Warehouse;
using Microsoft.AspNetCore.Mvc;

namespace CloudBar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : BaseController<Category>
    {
        public CategoriesController(IBaseService<Category> baseService) : base(baseService)
        {
        }
    }
}
