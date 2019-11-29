using Abp.UI;
using Abp.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
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
    public class TokenAuthController : RLCoreWebHostControllerBase
    {
        private readonly TokenAuthConfiguration _configuration;
        public TokenAuthController(TokenAuthConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        public AuthenticateResultModel Authenticate([FromBody] AuthenticateModel model)
        {
            if (model.UserNameOrEmailAddress == "root" && model.Password == "root")
            {
                var claims = new[]
                {
                    //用户名
                    new Claim(JwtRegisteredClaimNames.Sub, model.UserNameOrEmailAddress),
                    //jwt唯一标识
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    //签发时间
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

    }
}
