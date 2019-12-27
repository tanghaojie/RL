using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Extensions;
using Abp.UI;
using RLCore.Configuration.Optional.Entities;
using RLCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;

namespace RLCore.Services
{
    public class OptionTreeConfigurationAppServiceBase<TEntity, TEntityDto, TGetPagedInput, TCreateInput, TUpdateByIdInput>
       : OptionTreeConfigurationAppServiceBase<TEntity, TEntityDto, TGetPagedInput, TCreateInput, TUpdateByIdInput, int>
       where TEntity : OptionTreeBase<TEntity, int>
       where TEntityDto : IEntityDto<int>
       where TUpdateByIdInput : IEntityDto<int>
       where TGetPagedInput : IPagedResultRequest
    { }

    public class OptionTreeConfigurationAppServiceBase<TEntity, TEntityDto, TGetPagedInput, TCreateInput, TUpdateByIdInput, TPrimaryKey>
        : ApplicationService
        where TEntity : OptionTreeBase<TEntity, TPrimaryKey>
        where TEntityDto : IEntityDto<TPrimaryKey>
        where TUpdateByIdInput : IEntityDto<TPrimaryKey>
        where TGetPagedInput : IPagedResultRequest
    {
        protected virtual TEntityDto MapToEntityDto(TEntity entity)
        {
            return ObjectMapper.Map<TEntityDto>(entity);
        }

        protected virtual TEntity MapToEntity(TCreateInput createInput)
        {
            return ObjectMapper.Map<TEntity>(createInput);
        }

        protected virtual TEntity MapToEntity(TUpdateByIdInput updateInput)
        {
            return ObjectMapper.Map<TEntity>(updateInput);
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
