using System;
using System.Threading.Tasks;
using Abp.TestBase;
using RLCore.EntityFrameworkCore;
using RLCore.Tests.TestDatas;

namespace RLCore.Tests
{
    public class RLCoreTestBase : AbpIntegratedTestBase<RLCoreTestModule>
    {
        public RLCoreTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<RLCoreDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<RLCoreDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<RLCoreDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<RLCoreDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<RLCoreDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<RLCoreDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<RLCoreDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<RLCoreDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
