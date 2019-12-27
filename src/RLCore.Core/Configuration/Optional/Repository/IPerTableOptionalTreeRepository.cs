using Abp.Domain.Repositories;
using RLCore.Configuration.Optional.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace RLCore.Configuration.Optional.Repository
{
    public interface IPerTableOptionalTreeRepository<TEntity> : IPerTableOptionalTreeRepository<TEntity, int>
       where TEntity : class, ITreeEntity<TEntity>
    {
    }
    public interface IPerTableOptionalTreeRepository<TEntity, TPrimaryKey> : IRepository<TEntity, TPrimaryKey>
        where TEntity : class, ITreeEntity<TEntity, TPrimaryKey>
    {
        IQueryable<TEntity> GetAll(bool topOnly);

        int Count(bool topOnly);

        Task<int> CountAsync(bool topOnly);
    }
}
