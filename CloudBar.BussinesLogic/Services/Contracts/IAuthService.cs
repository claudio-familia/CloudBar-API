using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBar.BusinessLogic.Services.Contracts
{
    public interface IAuthService
    {
        public IActionResult Login(string username, string password);
        public string Encrypt(string text);
        public string Decrypt(string text);        
    }
}
