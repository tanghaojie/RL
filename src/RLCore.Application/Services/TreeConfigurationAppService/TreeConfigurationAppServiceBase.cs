using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Extensions;
using Abp.UI;
using RLCore.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;

namespace RLCore.Services
{
    public abstract class TreeConfigurationAppServiceBase<TEntityDto, TGetPagedInput, TCreateInput, TUpdateByIdInput>
        : ApplicationService
        where TEntityDto : IEntityDto<int>
        where TUpdateByIdInput : IEntityDto<int>
        where TGetPagedInput : IPagedResultRequest
    {
        protected readonly ITreeConfigurationManager _treeConfigurationManager;

        protected TreeConfigurationAppServiceBase(ITreeConfigurationManager treeConfigurationManager)
        {
            _treeConfigurationManager = treeConfigurationManager;
        }

        protected virtual TEntityDto MapToEntityDto(TreeConfiguration entity)
        {
            return ObjectMapper.Map<TEntityDto>(entity);
        }

        protected virtual TreeConfiguration MapToEntity(TCreateInput createInput)
        {
            return ObjectMapper.Map<TreeConfiguration>(createInput);
        }

        protected virtual TreeConfiguration MapToEntity(TUpdateByIdInput updateInput)
        {
            return ObjectMapper.Map<TreeConfiguration>(updateInput);
        }

        protected virtual IQueryable<TreeConfiguration> ApplySorting(IQueryable<TreeConfiguration> query, TGetPagedInput input)
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

        protected virtual IQueryable<TreeConfiguration> ApplyPaging(IQueryable<TreeConfiguration> query, TGetPagedInput input)
        {
            return query.Skip(input.SkipCount).Take(input.MaxResultCount);
        }

        protected virtual void Forbidden()
        {
            throw new UserFriendlyException(403, "Forbidden");
        }
    }
}
