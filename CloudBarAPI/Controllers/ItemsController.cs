using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudBar.BusinessLogic.Services.Contracts;
using CloudBar.Domain.Warehouse;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CloudBar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : BaseController<Item>
    {
        private readonly IBaseService<Item> _baseService;
        public ItemsController(IBaseService<Item> baseService) : base(baseService)
        {
            _baseService = baseService;
        }

        [HttpGet]
        public override IActionResult Get(string sortExpression)
        {
            var response = _baseService.GetAll(item => item.Include(or => or.Creator)
                                                                  .Include(or => or.Category)
                                                                  .Include(or => or.Place),
                                                     item => item.Active.Value);

            return Ok(response);
        }

        [HttpGet]
        [Route("search/{searchCriteria}")]
        public IActionResult GetBySearchCriteria(string searchCriteria)
        {
            var response = _baseService.GetAll(
                items => items.Include(x => x.Category)
                              .Where(i => i.Name.Contains(searchCriteria) || i.Description.Contains(searchCriteria)
                              || i.Category.Name.Contains(searchCriteria) || i.Category.Description.Contains(searchCriteria))
                );

            if(response == null || response.Count() == 0) return NotFound("No hay resultados disponibles con el parametro de busqueda");

            return Ok(response);
        }
    }
}
