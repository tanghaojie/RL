using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using RLCore.Configuration;
using RLCore.Configuration.Optional.Entities;
using RLCore.Configuration.Optional.Manager;
using RLCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLCore.Services
{
    public abstract class AsyncOptionTreeSharedTableConfigurationAppService
        <TEntityDto, TGetConfigPagedInput, TCreateInput, TUpdateByIdInput>
        : OptionTreeSharedTableConfigurationAppServiceBase<TEntityDto, TGetConfigPagedInput, TCreateInput, TUpdateByIdInput>,
        IAsyncOptionTreeSharedTableConfigurationAppService<TEntityDto, TGetConfigPagedInput, TCreateInput, TUpdateByIdInput>
        where TEntityDto : IEntityDto
        where TGetConfigPagedInput : IOptionalTreePagedResultRequest
        where TUpdateByIdInput : IEntityDto
    {
        public abstract string ConfigurationName { get; set; }

        public AsyncOptionTreeSharedTableConfigurationAppService(IOptionTreeSharedTableConfigurationManager ConfigurationManager)
            : base(ConfigurationManager)
        { }

        protected virtual bool GetSingleByIdEnabled { get; set; } = true;
        protected virtual bool CreateEnabled { get; set; } = true;
        protected virtual bool UpdateByIdEnabled { get; set; } = true;
        protected virtual bool DeleteByIdEnabled { get; set; } = true;
        protected virtual bool GetPagedEnabled { get; set; } = true;
        protected virtual bool GetAllEnabled { get; set; } = true;

        public virtual async Task<TEntityDto> GetSingleById(int id)
        {
            if (!GetSingleByIdEnabled) { Forbidden(); }

            var entity = await GetEntityByIdAsync(id);
            return MapToEntityDto(entity);
        }

        public virtual async Task<TEntityDto> Create(TCreateInput input)
        {
            if (!CreateEnabled) { Forbidden(); }

            var entity = MapToEntity(input);
            await _ConfigurationManager.AddAsync(ConfigurationName, entity);
            await CurrentUnitOfWork.SaveChangesAsync();
            return MapToEntityDto(entity);
        }

        public virtual async Task<TEntityDto> UpdateById(TUpdateByIdInput input)
        {
            if (!UpdateByIdEnabled) { Forbidden(); }

            var entity = await GetEntityByIdAsync(input.Id);
            await _ConfigurationManager.UpdateAsync(MapToEntity(input));
            CurrentUnitOfWork.SaveChanges();
            return MapToEntityDto(entity);
        }

        public virtual Task DeleteById(int id)
        {
            if (!DeleteByIdEnabled) { Forbidden(); }

            return _ConfigurationManager.DeleteAsync(id);
        }

        public virtual async Task<PagedResultDto<TEntityDto>> GetPaged(TGetConfigPagedInput input)
        {
            if (!GetPagedEnabled) { Forbidden(); }

            var query = _ConfigurationManager.GetAll(ConfigurationName, input.TopOnly);
            var total = await _ConfigurationManager.CountAsync(ConfigurationName, input.TopOnly);
            query = ApplySorting(query, input);
            query = ApplyPaging(query, input);
            var entities = await query.ToListAsync();
            return new PagedResultDto<TEntityDto>(total, entities.Select(MapToEntityDto).ToList());
        }

        public virtual async Task<IListResult<TEntityDto>> GetAll()
        {
            if (!GetAllEnabled) { Forbidden(); }

            var list = await _ConfigurationManager.GetAllAsync(ConfigurationName);
            return new ListResultDto<TEntityDto>(list.Select(MapToEntityDto).ToList());
        }


        protected virtual Task<OptionTreeSharedTable> GetEntityByIdAsync(int id)
        {
            return _ConfigurationManager.GetAsync(id);
        }


    }




}
