using Abp.Modules;
using Abp.Reflection.Extensions;
using RLCore.Localization;

namespace RLCore
{
    public class RLCoreCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabled = false;
            Configuration.Localization.IsEnabled = false;

            RLCoreLocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RLCoreCoreModule).GetAssembly());
        }
    }
}