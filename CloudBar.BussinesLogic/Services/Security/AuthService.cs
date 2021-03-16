using CloudBar.BusinessLogic.Services.Contracts;
using CloudBar.Common.Services.Contracts;
using CloudBar.DataAccess.Repositories.Contracts;
using CloudBar.Domain.Security;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;

namespace CloudBar.BusinessLogic.Services.Security
{
    public class AuthService : IAuthService
    {
        private readonly IDataRepository<User> _baseRepository;
        private readonly IConfiguration configuration;
        private readonly ICryptographyService _cryptographyService;
        public AuthService(IDataRepository<User> baseRepository,
                           IConfiguration _configuration,
                           ICryptographyService cryptographyService)
        {
            _baseRepository = baseRepository;
            configuration = _configuration;
            _cryptographyService = cryptographyService;
        }

        public string Decrypt(string text)
        {
            return _cryptographyService.Decrypt(text, configuration["Authentication:SecretKey"]);
        }

        public string Encrypt(string text)
        {
            return _cryptographyService.Encrypt(text, configuration["Authentication:SecretKey"]);
        }

        public IActionResult Login(string username, string password)
        {
            try
            {
                if (_baseRepository.Exists(user => user.Username == username))
                {
                    string passwordEncrypt = password;//Encrypt(password);

                    User user = _baseRepository.Get(user => user.Username == username && user.Password == passwordEncrypt);

                    if (user != null)
                    {
                        return new OkObjectResult(new { user.Username, token = GenerateJWT(user) });
                    }

                    return new UnauthorizedObjectResult("Invalid Password");
                }

                return new NotFoundObjectResult("Invalid User");
            }
            catch (Exception)
            {
                return new StatusCodeResult((int)HttpStatusCode.InternalServerError);
            }
        }

        private string GenerateJWT(User user)
        {
            List<Claim> claims = new List<Claim>()
            {
                 new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                 new Claim(ClaimTypes.Name, user.Username.ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Authentication:SecretKey"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
            var expires = DateTime.Now.AddMinutes(60);

            var token = new JwtSecurityToken(
                issuer: configuration["Authentication:Issuer"],
                audience: configuration["Authentication:Audience"],
                claims,
                expires: expires,
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
