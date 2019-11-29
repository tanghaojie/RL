using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace RLCore.EntityFrameworkCore
{
    [DependsOn(
        typeof(RLCoreCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class RLCoreEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RLCoreEntityFrameworkCoreModule).GetAssembly());
        }
    }
}