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
using Microsoft.AspNetCore.Mvc.Filters;
using Abp.Configuration.Startup;

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
        private readonly IHostingEnvironment _env;

        public RLCoreWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
            _env = env;
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<RLCoreNavigationProvider>();
            ConfigureFileSystem();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RLCoreWebModule).GetAssembly());
        }

        private void ConfigureFileSystem()
        {
            IocManager.Register<FileSystem.FileSystem>();
            var fileSystem = IocManager.Resolve<FileSystem.FileSystem>();
            fileSystem.RootPath = _env.ContentRootPath;
            fileSystem.WebRootPath = _env.WebRootPath;   
        }
    }
}