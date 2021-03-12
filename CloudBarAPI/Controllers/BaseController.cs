using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudBar.BusinessLogic.Services.Contracts;
using CloudBar.Controllers.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CloudBar.Controllers
{
    public class BaseController<T> : Controller, IBaseController<T> where T : class, new()
    {
        private IBaseService<T> _baseService;
        public BaseController(IBaseService<T> baseService)
        {
            _baseService = baseService;
        }

        public IActionResult Get(string sortExpression)
        {
            return Ok(_baseService.GetAll(sortExpression));
        }

        public IActionResult Get(int id)
        {
            var response = _baseService.Get(id);

            if (response == null) return NotFound();

            return Ok(response);
        }

        public IActionResult Post(T entity)
        {
            var response = _baseService.Add(entity);

            return Ok(response);
        }

        public IActionResult Put(T entity)
        {
            var response = _baseService.Update(entity);

            return Ok(response);
        }       
    }
}
