using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace RLCore
{
    [DependsOn(
        typeof(RLCoreCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class RLCoreApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RLCoreApplicationModule).GetAssembly());
        }
    }
}