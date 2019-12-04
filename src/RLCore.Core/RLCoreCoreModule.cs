using Abp.Configuration.Startup;
using Abp.Dependency;
using Abp.Modules;
using Abp.MultiTenancy;
using Abp.Reflection.Extensions;
using Abp.Runtime;
using Abp.Runtime.Security;
using Abp.Runtime.Session;
using RLCore.Localization;
using System;
using System.Linq;

namespace RLCore
{
    public class RLCoreCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabled = false;
            Configuration.Localization.IsEnabled = false;
            Configuration.Authorization.IsEnabled = true;
            Configuration.MultiTenancy.IsEnabled = false;

            RLCoreLocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RLCoreCoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {

        }
    }
}