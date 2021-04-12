using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudBar.BusinessLogic.Services.Contracts;
using CloudBar.Domain.General;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CloudBar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class EmployeesController : BaseController<Employee>
    {
        public EmployeesController(IBaseService<Employee> baseService) : base(baseService)
        {
        }
    }
}
