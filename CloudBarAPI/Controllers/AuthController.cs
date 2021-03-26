using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using CloudBar.BusinessLogic.Dto;
using CloudBar.BusinessLogic.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CloudBar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public IActionResult Login(AuthDto user)
        {
            return _authService.Login(user.Username, user.Password);
        }

        [Authorize]
        [HttpPost("validate")]
        public IActionResult Validate()
        {
            return Ok();
        }
    }
}
