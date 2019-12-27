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
    public class OptionTreeSharedTableRepository : RLCoreRepositoryBase<OptionTreeSharedTable>, IOptionTreeSharedTableRepository
    {
        public OptionTreeSharedTableRepository(IDbContextProvider<RLCoreDbContext> dbContextProvider)
        : base(dbContextProvider)
        {
        
        }

        public override IQueryable<OptionTreeSharedTable> GetAll()
        {
            return base.GetAll().Include(x => x.Subs).AsEnumerable().AsQueryable();
        }

        public override List<OptionTreeSharedTable> GetAllList()
        {
            return base.GetAll().Include(x => x.Subs).AsEnumerable().ToList();
        }

        public override List<OptionTreeSharedTable> GetAllList(Expression<Func<OptionTreeSharedTable, bool>> predicate)
        {
            return base.GetAll().Include(x => x.Subs).AsEnumerable().Where(predicate.Compile()).ToList();
        }

        public override Task<List<OptionTreeSharedTable>> GetAllListAsync()
        {
            return base.GetAll().Include(x => x.Subs).ToAsyncEnumerable().ToList();
        }

        public override Task<List<OptionTreeSharedTable>> GetAllListAsync(Expression<Func<OptionTreeSharedTable, bool>> predicate)
        {
            return base.GetAll().Include(x => x.Subs).ToAsyncEnumerable().Where(predicate.Compile()).ToList();
        }

        public override OptionTreeSharedTable Get(int id)
        {
            return base.GetAll().Include(x => x.Subs).AsEnumerable().Where(x => x.Id == id).FirstOrDefault();
        }

        public override Task<OptionTreeSharedTable> GetAsync(int id)
        {
            return base.GetAll().Include(x => x.Subs).ToAsyncEnumerable().Where(x => x.Id == id).FirstOrDefault();
        }

    }
}
