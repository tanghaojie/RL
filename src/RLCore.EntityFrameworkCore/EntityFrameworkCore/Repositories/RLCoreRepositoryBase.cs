using Abp.Domain.Entities;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;

namespace RLCore.EntityFrameworkCore.Repositories
{
    public abstract class RLCoreRepositoryBase<TEntity, TPrimaryKey> : EfCoreRepositoryBase<RLCoreDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected RLCoreRepositoryBase(IDbContextProvider<RLCoreDbContext> dbContextProvider) : base(dbContextProvider) { }
    }

    public abstract class RLCoreRepositoryBase<TEntity> : RLCoreRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected RLCoreRepositoryBase(IDbContextProvider<RLCoreDbContext> dbContextProvider) : base(dbContextProvider) { }
    }
}
