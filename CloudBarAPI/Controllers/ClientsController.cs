using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudBar.BusinessLogic.Services.Contracts;
using CloudBar.Domain.Sale;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CloudBar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ClientsController : BaseController<Client>
    {
        public ClientsController(IBaseService<Client> baseService) : base(baseService)
        {
        }
    }
}
