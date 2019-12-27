using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RLCore.Configuration.Optional.Entities;
using RLCore.Configuration.Optional.Repository;
using RLCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RLCore.EntityFrameworkCore.Repositories
{
    public class OptionTreeRepository<TSelfEntity> : OptionTreeRepository<TSelfEntity, int>, IOptionTreeRepository<TSelfEntity>
        where TSelfEntity : OptionTreeBase<TSelfEntity>
    {
        public OptionTreeRepository(IDbContextProvider<RLCoreDbContext> dbContextProvider)
           : base(dbContextProvider) { }
    }
    public class OptionTreeRepository<TEntity, TPrimaryKey> : RLCoreRepositoryBase<TEntity, TPrimaryKey>, IOptionTreeRepository<TEntity, TPrimaryKey>
        where TEntity : OptionTreeBase<TEntity, TPrimaryKey>
    {
        public OptionTreeRepository(IDbContextProvider<RLCoreDbContext> dbContextProvider)
            : base(dbContextProvider)
        { }

        public override IQueryable<TEntity> GetAll()
        {
            return base.GetAll().Include(x => x.Subs);
        }

        public override List<TEntity> GetAllList()
        {
            return base.GetAll().Include(x => x.Subs).AsEnumerable().ToList();
        }

        public override List<TEntity> GetAllList(Expression<Func<TEntity, bool>> predicate)
        {
            return base.GetAll().Include(x => x.Subs).AsEnumerable().Where(predicate.Compile()).ToList();
        }

        public override Task<List<TEntity>> GetAllListAsync()
        {
            return base.GetAll().Include(x => x.Subs).ToAsyncEnumerable().ToList();
        }

        public override Task<List<TEntity>> GetAllListAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return base.GetAll().Include(x => x.Subs).ToAsyncEnumerable().Where(predicate.Compile()).ToList();
        }

        public override TEntity Get(TPrimaryKey id)
        {
            return base.GetAll().Include(x => x.Subs).AsEnumerable().Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public override Task<TEntity> GetAsync(TPrimaryKey id)
        {
            return base.GetAll().Include(x => x.Subs).ToAsyncEnumerable().Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public override TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return base.GetAll().Include(x => x.Subs).FirstOrDefault(predicate);
        }

        public override TEntity FirstOrDefault(TPrimaryKey id)
        {
            return base.GetAll().Include(x => x.Subs).FirstOrDefault(x => x.Id.Equals(id));
        }

        public override Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return base.GetAll().Include(x => x.Subs).FirstOrDefaultAsync(predicate);
        }

        public override Task<TEntity> FirstOrDefaultAsync(TPrimaryKey id)
        {
            return base.GetAll().Include(x => x.Subs).FirstOrDefaultAsync(x => x.Id.Equals(id));
        }

        public override TEntity Single(Expression<Func<TEntity, bool>> predicate)
        {
            return base.GetAll().Include(x => x.Subs).Single(predicate);
        }

        public override Task<TEntity> SingleAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return base.GetAll().Include(x => x.Subs).SingleAsync(predicate);
        }

    }
}
