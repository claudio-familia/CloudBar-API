using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudBar.BusinessLogic.Services.Contracts;
using CloudBar.Domain.General;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CloudBar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class EmployeesController : BaseController<Employee>
    {
        private readonly IBaseService<Employee> _baseService;
        public EmployeesController(IBaseService<Employee> baseService) : base(baseService)
        {
            _baseService = baseService;
        }

        [HttpGet]
        public override IActionResult Get(string sortExpression)
        {
            var response = _baseService.GetAll(employees => employees.Include(or => or.Creator)
                                                                  .Include(or => or.Person));

            return Ok(response);
        }
    }
}
