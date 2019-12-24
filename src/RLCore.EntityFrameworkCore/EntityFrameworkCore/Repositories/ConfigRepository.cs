using Abp.Collections.Extensions;
using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RLCore.Configuration;
using RLCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RLCore.EntityFrameworkCore.Repositories
{
    public class ConfigRepository : RLCoreRepositoryBase<TreeConfiguration>, IConfigRepository
    {
        public ConfigRepository(IDbContextProvider<RLCoreDbContext> dbContextProvider)
        : base(dbContextProvider)
        {

        }

        public override IQueryable<TreeConfiguration> GetAll()
        {
            return base.GetAll().Include(x => x.Subs).AsEnumerable().AsQueryable();
        }

        public override List<TreeConfiguration> GetAllList()
        {
            return base.GetAll().Include(x => x.Subs).AsEnumerable().ToList();
        }

        public override List<TreeConfiguration> GetAllList(Expression<Func<TreeConfiguration, bool>> predicate)
        {
            return base.GetAll().Include(x => x.Subs).AsEnumerable().Where(predicate.Compile()).ToList();
        }

        public override Task<List<TreeConfiguration>> GetAllListAsync()
        {
            return base.GetAll().Include(x => x.Subs).ToAsyncEnumerable().ToList();
        }

        public override Task<List<TreeConfiguration>> GetAllListAsync(Expression<Func<TreeConfiguration, bool>> predicate)
        {
            return base.GetAll().Include(x => x.Subs).ToAsyncEnumerable().Where(predicate.Compile()).ToList();
        }

        public override TreeConfiguration Get(int id)
        {
            return base.GetAll().Include(x => x.Subs).AsEnumerable().Where(x => x.Id == id).FirstOrDefault();
        }

        public override Task<TreeConfiguration> GetAsync(int id)
        {
            return base.GetAll().Include(x => x.Subs).ToAsyncEnumerable().Where(x => x.Id == id).FirstOrDefault();
        }

     
    }
}
