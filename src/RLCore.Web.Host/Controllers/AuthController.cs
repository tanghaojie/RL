using Abp.Domain.Repositories;
using Abp.Runtime.Security;
using Abp.Runtime.Session;
using Abp.UI;
using Abp.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using RLCore.Encryption;
using RLCore.Users;
using RLCore.Web.Host.Authorization.JwtBearer;
using RLCore.Web.Host.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace RLCore.Web.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : RLCoreWebHostControllerBase
    {
        private readonly TokenAuthConfiguration _configuration;
        private readonly IRepository<User> _userRepository;

        public IPrincipalAccessor Pa { get; set; }

        private readonly IHttpContextAccessor _httpContextAccessor;

        public AuthController(
            TokenAuthConfiguration configuration,
            IRepository<User> userRepository,
            IHttpContextAccessor httpContextAccessor
            )
        {
            _configuration = configuration;
            _userRepository = userRepository; _httpContextAccessor = httpContextAccessor;
        }

        [HttpPost]
        public AuthenticateResultModel Authenticate([FromBody] AuthenticateModel model)
        {
            var username = model.Username;
            var password = Password.MD5(model.Password);
            var user = _userRepository.GetAll().Where(u => u.Username == username && u.Password == password);
            if (user.Count() > 0)
            {
                var claims = new[] {
                    new Claim(ClaimTypes.NameIdentifier, user.First().Id.ToString()),
                    new Claim(ClaimTypes.Name, model.Username),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Iat, DateTimeOffset.Now.ToUnixTimeSeconds().ToString(), ClaimValueTypes.Integer64),
                };
                var now = DateTime.UtcNow;
                var token = new JwtSecurityToken(
                    issuer: _configuration.Issuer,
                    audience: _configuration.Audience,
                    claims: claims,
                    notBefore: now,
                    expires: now.Add(_configuration.Expiration),
                    signingCredentials: _configuration.SigningCredentials
                    );

                var accessToken = new JwtSecurityTokenHandler().WriteToken(token);
                var expInSeconds = (int)_configuration.Expiration.TotalSeconds;
                return new AuthenticateResultModel
                {
                    AccessToken = accessToken,
                    ExpireInSeconds = expInSeconds
                };
            }
            throw new UserFriendlyException(401, "", "");
        }

        [HttpGet]
        public string X()
        {
            var ss = AbpSession;
            return "123";
        }

    }
}
