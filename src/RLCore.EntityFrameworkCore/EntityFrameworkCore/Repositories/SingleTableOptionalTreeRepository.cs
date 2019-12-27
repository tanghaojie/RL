using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RLCore.Configuration.Optional.Entities;
using RLCore.Configuration.Optional.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RLCore.EntityFrameworkCore.Repositories
{
    public class SingleTableOptionalTreeRepository : RLCoreRepositoryBase<SingleTableOptionalTree>, ISingleTableOptionalTreeRepository
    {
        public SingleTableOptionalTreeRepository(IDbContextProvider<RLCoreDbContext> dbContextProvider)
        : base(dbContextProvider)
        {
        
        }

        public override IQueryable<SingleTableOptionalTree> GetAll()
        {
            return base.GetAll().Include(x => x.Subs).AsEnumerable().AsQueryable();
        }

        public override List<SingleTableOptionalTree> GetAllList()
        {
            return base.GetAll().Include(x => x.Subs).AsEnumerable().ToList();
        }

        public override List<SingleTableOptionalTree> GetAllList(Expression<Func<SingleTableOptionalTree, bool>> predicate)
        {
            return base.GetAll().Include(x => x.Subs).AsEnumerable().Where(predicate.Compile()).ToList();
        }

        public override Task<List<SingleTableOptionalTree>> GetAllListAsync()
        {
            return base.GetAll().Include(x => x.Subs).ToAsyncEnumerable().ToList();
        }

        public override Task<List<SingleTableOptionalTree>> GetAllListAsync(Expression<Func<SingleTableOptionalTree, bool>> predicate)
        {
            return base.GetAll().Include(x => x.Subs).ToAsyncEnumerable().Where(predicate.Compile()).ToList();
        }

        public override SingleTableOptionalTree Get(int id)
        {
            return base.GetAll().Include(x => x.Subs).AsEnumerable().Where(x => x.Id == id).FirstOrDefault();
        }

        public override Task<SingleTableOptionalTree> GetAsync(int id)
        {
            return base.GetAll().Include(x => x.Subs).ToAsyncEnumerable().Where(x => x.Id == id).FirstOrDefault();
        }

    }
}
