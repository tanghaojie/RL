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
            var thisAssembly = typeof(RLCoreApplicationModule).GetAssembly();
            IocManager.RegisterAssemblyByConvention(thisAssembly);
            Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg => cfg.AddMaps(thisAssembly));
        }
    }
}