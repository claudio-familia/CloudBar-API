using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudBar.BusinessLogic.Services.Contracts;
using CloudBar.Domain.Sale;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CloudBar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ClientsController : BaseController<Client>
    {
        private readonly IBaseService<Client> _baseService;
        public ClientsController(IBaseService<Client> baseService) : base(baseService)
        {
            _baseService = baseService;
        }

        [HttpGet]
        public override IActionResult Get(string sortExpression)
        {
            var response = _baseService.GetAll(clients => clients.Include(or => or.Creator)
                                                                  .Include(or => or.Person));

            return Ok(response);
        }
    }
}
