using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.MicroKernel.Registration;
using RLCore.Configuration.Optional.Repository;
using RLCore.EntityFrameworkCore.Repositories;

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
            

            IocManager.IocContainer.Register(Component.For(typeof(IPerTableOptionalTreeRepository<>)).ImplementedBy(typeof(PerTableOptionalTreeRepository<>)).LifestyleTransient());
        }
    }
}