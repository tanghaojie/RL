using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using RLCore.Configuration;
using RLCore.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using RLCore.Web.Host;
using Abp.Runtime.Session;
using Abp.Dependency;

namespace RLCore.Web.Startup
{
    [DependsOn(
        typeof(RLCoreApplicationModule),
        typeof(RLCoreEntityFrameworkCoreModule),
        typeof(AbpAspNetCoreModule),
        typeof(RLCoreWebHostModule)
        )]
    public class RLCoreWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public RLCoreWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<RLCoreNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RLCoreWebModule).GetAssembly());
        }
    }
}