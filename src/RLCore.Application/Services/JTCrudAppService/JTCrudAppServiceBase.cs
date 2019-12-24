using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.UI;
using System.Linq;
using System.Linq.Dynamic.Core;
namespace RLCore.Services
{
    public abstract class JTCrudAppServiceBase<TEntity, TEntityDto, TGetPagedInput, TCreateInput, TUpdateByIdInput>
        : JTCrudAppServiceBase<TEntity, TEntityDto, int, TGetPagedInput, TCreateInput, TUpdateByIdInput>
        where TEntity : class, IEntity<int>
        where TEntityDto : IEntityDto<int>
        where TUpdateByIdInput : IEntityDto<int>
        where TGetPagedInput : IPagedResultRequest
    {
        protected JTCrudAppServiceBase(IRepository<TEntity, int> repository) : base(repository)
        {
        }
    }


    public abstract class JTCrudAppServiceBase<TEntity, TEntityDto, TPrimaryKey, TGetPagedInput, TCreateInput, TUpdateByIdInput>
        : ApplicationService
        where TEntity : class, IEntity<TPrimaryKey>
        where TEntityDto : IEntityDto<TPrimaryKey>
        where TUpdateByIdInput : IEntityDto<TPrimaryKey>
        where TGetPagedInput : IPagedResultRequest
    {
        protected readonly IRepository<TEntity, TPrimaryKey> Repository;

        protected JTCrudAppServiceBase(IRepository<TEntity, TPrimaryKey> repository)
        {
            Repository = repository;
        }

        protected virtual TEntityDto MapToEntityDto(TEntity entity)
        {
            return ObjectMapper.Map<TEntityDto>(entity);
        }

        protected virtual TEntity MapToEntity(TCreateInput createInput)
        {
            return ObjectMapper.Map<TEntity>(createInput);
        }

        protected virtual void MapToEntity(TUpdateByIdInput updateInput, TEntity entity)
        {
            ObjectMapper.Map(updateInput, entity);
        }

        protected virtual IQueryable<TEntity> ApplySorting(IQueryable<TEntity> query, TGetPagedInput input)
        {
            if (input is ISortedResultRequest sortInput)
            {
                if (!sortInput.Sorting.IsNullOrWhiteSpace())
                {
                    return query.OrderBy(sortInput.Sorting);
                }
            }
            return query.OrderBy(e => e.Id);
        }

        protected virtual IQueryable<TEntity> ApplyPaging(IQueryable<TEntity> query, TGetPagedInput input)
        {
            return query.Skip(input.SkipCount).Take(input.MaxResultCount);
        }

        protected virtual void Forbidden()
        {
            throw new UserFriendlyException(403, "Forbidden");
        }
    }
}