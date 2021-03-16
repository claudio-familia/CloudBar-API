﻿using CloudBar.BusinessLogic.Services.Contracts;
using CloudBar.Domain.Security;
using Microsoft.AspNetCore.Mvc;

namespace CloudBar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : BaseController<Role>
    {
        public RoleController(IBaseService<Role> baseService) : base(baseService)
        {
        }
    }
}