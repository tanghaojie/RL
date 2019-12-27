using Abp.Domain.Repositories;
using RLCore.Configuration.Optional.Entities;
using RLCore.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace RLCore.Configuration.Optional.Repository
{
    public interface IOptionTreeRepository<TEntity> : IOptionTreeRepository<TEntity, int>
       where TEntity : OptionTreeBase<TEntity>
    {
    }
    public interface IOptionTreeRepository<TEntity, TPrimaryKey> : IRepository<TEntity, TPrimaryKey>
        where TEntity : OptionTreeBase<TEntity, TPrimaryKey>
    {
        IQueryable<TEntity> GetAll(bool topOnly);

        int Count(bool topOnly);

        Task<int> CountAsync(bool topOnly);
    }
}
