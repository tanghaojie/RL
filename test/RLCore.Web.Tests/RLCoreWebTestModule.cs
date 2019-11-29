using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using RLCore.Web.Startup;
namespace RLCore.Web.Tests
{
    [DependsOn(
        typeof(RLCoreWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class RLCoreWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RLCoreWebTestModule).GetAssembly());
        }
    }
}