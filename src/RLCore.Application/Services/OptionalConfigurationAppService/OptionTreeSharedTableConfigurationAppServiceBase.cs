using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Extensions;
using Abp.UI;
using RLCore.Configuration.Optional.Entities;
using RLCore.Configuration.Optional.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Dynamic.Core;

namespace RLCore.Services
{
    public class OptionTreeSharedTableConfigurationAppServiceBase< TEntityDto, TGetPagedInput, TCreateInput, TUpdateByIdInput>
        : ApplicationService
        where TEntityDto : IEntityDto
        where TUpdateByIdInput : IEntityDto
        where TGetPagedInput : IPagedResultRequest
    {
        protected readonly IOptionTreeSharedTableConfigurationManager _ConfigurationManager;

        public OptionTreeSharedTableConfigurationAppServiceBase(IOptionTreeSharedTableConfigurationManager ConfigurationManager)
        {
            _ConfigurationManager = ConfigurationManager;
        }

        protected virtual TEntityDto MapToEntityDto(OptionTreeSharedTable entity)
        {
            return ObjectMapper.Map<TEntityDto>(entity);
        }

        protected virtual OptionTreeSharedTable MapToEntity(TCreateInput createInput)
        {
            return ObjectMapper.Map<OptionTreeSharedTable>(createInput);
        }

        protected virtual OptionTreeSharedTable MapToEntity(TUpdateByIdInput updateInput)
        {
            return ObjectMapper.Map<OptionTreeSharedTable>(updateInput);
        }

        protected virtual IQueryable<OptionTreeSharedTable> ApplySorting(IQueryable<OptionTreeSharedTable> query, TGetPagedInput input)
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

        protected virtual IQueryable<OptionTreeSharedTable> ApplyPaging(IQueryable<OptionTreeSharedTable> query, TGetPagedInput input)
        {
            return query.Skip(input.SkipCount).Take(input.MaxResultCount);
        }

        protected virtual void Forbidden()
        {
            throw new UserFriendlyException(403, "Forbidden");
        }
    }
}
