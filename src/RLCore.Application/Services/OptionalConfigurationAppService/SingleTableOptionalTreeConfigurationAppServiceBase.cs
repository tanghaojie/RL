//using Abp.Application.Services;
//using Abp.Application.Services.Dto;
//using Abp.Extensions;
//using Abp.UI;
//using RLCore.Configuration;
//using RLCore.Configuration.Optional.Entity;
//using RLCore.Configuration.Optional.Manager;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Dynamic.Core;
//using System.Text;

//namespace RLCore.Services
//{
//    public abstract class SingleTableOptionalTreeConfigurationAppServiceBase<TEntityDto, TGetPagedInput, TCreateInput, TUpdateByIdInput>
//        : ApplicationService
//        where TEntityDto : IEntityDto<int>
//        where TUpdateByIdInput : IEntityDto<int>
//        where TGetPagedInput : IPagedResultRequest
//    {
//        protected readonly ISingleTableOptionalTreeConfigurationManager _treeConfigurationManager;

//        protected SingleTableOptionalTreeConfigurationAppServiceBase(ISingleTableOptionalTreeConfigurationManager treeConfigurationManager)
//        {
//            _treeConfigurationManager = treeConfigurationManager;
//        }

//        protected virtual TEntityDto MapToEntityDto(SingleTableOptionalTree entity)
//        {
//            return ObjectMapper.Map<TEntityDto>(entity);
//        }

//        protected virtual SingleTableOptionalTree MapToEntity(TCreateInput createInput)
//        {
//            return ObjectMapper.Map<SingleTableOptionalTree>(createInput);
//        }

//        protected virtual SingleTableOptionalTree MapToEntity(TUpdateByIdInput updateInput)
//        {
//            return ObjectMapper.Map<SingleTableOptionalTree>(updateInput);
//        }

//        protected virtual IQueryable<SingleTableOptionalTree> ApplySorting(IQueryable<SingleTableOptionalTree> query, TGetPagedInput input)
//        {
//            if (input is ISortedResultRequest sortInput)
//            {
//                if (!sortInput.Sorting.IsNullOrWhiteSpace())
//                {
//                    return query.OrderBy(sortInput.Sorting);
//                }
//            }
//            return query.OrderBy(e => e.Id);
//        }

//        protected virtual IQueryable<SingleTableOptionalTree> ApplyPaging(IQueryable<SingleTableOptionalTree> query, TGetPagedInput input)
//        {
//            return query.Skip(input.SkipCount).Take(input.MaxResultCount);
//        }

//        protected virtual void Forbidden()
//        {
//            throw new UserFriendlyException(403, "Forbidden");
//        }
//    }
//}
