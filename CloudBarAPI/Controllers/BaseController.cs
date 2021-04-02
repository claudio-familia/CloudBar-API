using CloudBar.BusinessLogic.Services.Contracts;
using CloudBar.Controllers.Contracts;
using CloudBar.Domain;
using Microsoft.AspNetCore.Mvc;

namespace CloudBar.Controllers
{    
    public class BaseController<T> : Controller, IBaseController<T> where T : class, IAuditableEntity, new()
    {
        private readonly IBaseService<T> _baseService;
        public BaseController(IBaseService<T> baseService)
        {
            _baseService = baseService;
        }

        [HttpGet]
        public virtual IActionResult Get(string sortExpression)
        {
            return Ok(_baseService.GetAll(sortExpression));
        }

        [HttpGet("{id}")]
        public virtual IActionResult Get(int id)
        {
            var response = _baseService.Get(id);

            if (response == null) return NotFound();

            return Ok(response);
        }

        [HttpPost]
        public virtual IActionResult Post(T entity)
        {
            var response = _baseService.Add(entity);

            return Ok(response);
        }

        [HttpPut]
        public virtual IActionResult Put(T entity)
        {
            var response = _baseService.Update(entity);

            return Ok(response);
        }

        [HttpDelete]
        [Route("id")]
        public virtual IActionResult Delete(int id)
        {
            var entity = _baseService.Get(id);

            entity.Active = false;

            var response = _baseService.Update(entity);

            return Ok(response);
        }
    }
}
