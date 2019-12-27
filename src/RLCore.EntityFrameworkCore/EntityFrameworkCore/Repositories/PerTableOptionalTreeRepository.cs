using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RLCore.Configuration.Optional.Entities;
using RLCore.Configuration.Optional.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RLCore.EntityFrameworkCore.Repositories
{
    public class PerTableOptionalTreeRepository<TSelfEntity> : PerTableOptionalTreeRepository<TSelfEntity, int>, IPerTableOptionalTreeRepository<TSelfEntity>
        where TSelfEntity : class, ITreeEntity<TSelfEntity>
    {
        public PerTableOptionalTreeRepository(IDbContextProvider<RLCoreDbContext> dbContextProvider)
           : base(dbContextProvider) { }
    }
    public class PerTableOptionalTreeRepository<TEntity, TPrimaryKey> : RLCoreRepositoryBase<TEntity, TPrimaryKey>, IPerTableOptionalTreeRepository<TEntity, TPrimaryKey>
        where TEntity : class, ITreeEntity<TEntity, TPrimaryKey>
    {
        public PerTableOptionalTreeRepository(IDbContextProvider<RLCoreDbContext> dbContextProvider)
        : base(dbContextProvider)
        {

        }

        public override IQueryable<TEntity> GetAll()
        {
            return base.GetAll().Include(x => x.Subs).AsQueryable();
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

        public IQueryable<TEntity> GetAll(bool topOnly)
        {
            var query = base.GetAll().Include(x => x.Subs);
            if (topOnly)
            {
                return query.Where(u => u.Parent == null);
            }
            return query;
        }

        public int Count(bool topOnly)
        {
            var query = base.GetAll();
            if (topOnly)
            {
                return query.Where(u => u.Parent == null).Count();
            }
            return query.Count();
        }

        public async Task<int> CountAsync(bool topOnly)
        {
            var query = base.GetAll();
            if (topOnly)
            {
                return await query.Where(u => u.Parent == null).CountAsync();
            }
            return await query.CountAsync();
        }

    }
}
