using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using RLCore.Configuration;
using RLCore.Web.Host.Authorization.JwtBearer;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.Web.Host
{
    [DependsOn(
    typeof(RLCoreApplicationModule))]
    public class RLCoreWebHostModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;
        public RLCoreWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RLCoreWebHostModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(RLCoreConsts.ConnectionStringName);
            Configuration.Modules.AbpAspNetCore()
              .CreateControllersForAppServices(
                  typeof(RLCoreApplicationModule).GetAssembly()
              );

            ConfigureTokenAuth();
        }

        private void ConfigureTokenAuth()
        {
            IocManager.Register<TokenAuthConfiguration>();
            var tokenAuthConfig = IocManager.Resolve<TokenAuthConfiguration>();

            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_appConfiguration["Authentication:JwtBearer:SecurityKey"]));
            tokenAuthConfig.SecurityKey = symmetricSecurityKey;
            tokenAuthConfig.SigningCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            tokenAuthConfig.Issuer = _appConfiguration["Authentication:JwtBearer:Issuer"];
            tokenAuthConfig.Audience = _appConfiguration["Authentication:JwtBearer:Audience"];
            tokenAuthConfig.Expiration = TimeSpan.FromHours(double.Parse(_appConfiguration["Authentication:JwtBearer:ExpireHours"]));
        }
    }
}
