using CloudBar.BusinessLogic.Services.Contracts;
using CloudBar.Controllers.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CloudBar.Controllers
{    
    public class BaseController<T> : Controller, IBaseController<T> where T : class, new()
    {
        private readonly IBaseService<T> _baseService;
        public BaseController(IBaseService<T> baseService)
        {
            _baseService = baseService;
        }

        [HttpGet]
        public IActionResult Get(string sortExpression)
        {
            return Ok(_baseService.GetAll(sortExpression));
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var response = _baseService.Get(id);

            if (response == null) return NotFound();

            return Ok(response);
        }

        [HttpPost]
        public IActionResult Post(T entity)
        {
            var response = _baseService.Add(entity);

            return Ok(response);
        }

        [HttpPut]
        public IActionResult Put(T entity)
        {
            var response = _baseService.Update(entity);

            return Ok(response);
        }
    }
}
