using Abp.Application.Services.Dto;
using Microsoft.EntityFrameworkCore;
using RLCore.Configuration.Optional.Entities;
using RLCore.Configuration.Optional.Repository;
using RLCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLCore.Services
{
    public abstract class AsyncPerTableOptionalTreeConfigurationAppService<TEntity, TEntityDto>
        : AsyncPerTableOptionalTreeConfigurationAppService<TEntity, TEntityDto, OptionalTreePagedResultRequest>,
        IAsyncPerTableOptionalTreeConfigurationAppService<TEntityDto, OptionalTreePagedResultRequest>
        where TEntity : class, ITreeEntity<TEntity>
        where TEntityDto : IEntityDto
    {
        public AsyncPerTableOptionalTreeConfigurationAppService(IPerTableOptionalTreeRepository<TEntity> Repository) : base(Repository) { }
    }

    public abstract class AsyncPerTableOptionalTreeConfigurationAppService<TEntity, TEntityDto, TGetConfigPagedInput>
        : AsyncPerTableOptionalTreeConfigurationAppService<TEntity, TEntityDto, TGetConfigPagedInput, TEntityDto>,
        IAsyncPerTableOptionalTreeConfigurationAppService<TEntityDto, TGetConfigPagedInput, TEntityDto>
        where TEntity : class, ITreeEntity<TEntity>
        where TEntityDto : IEntityDto
        where TGetConfigPagedInput : IOptionalTreePagedResultRequest
    {
        public AsyncPerTableOptionalTreeConfigurationAppService(IPerTableOptionalTreeRepository<TEntity> Repository) : base(Repository) { }
    }

    public abstract class AsyncPerTableOptionalTreeConfigurationAppService<TEntity, TEntityDto, TGetConfigPagedInput, TCreateInput>
        : AsyncPerTableOptionalTreeConfigurationAppService<TEntity, TEntityDto, TGetConfigPagedInput, TCreateInput, EntityDto<int>>,
        IAsyncPerTableOptionalTreeConfigurationAppService<TEntityDto, TGetConfigPagedInput, TCreateInput, EntityDto<int>>
        where TEntity : class, ITreeEntity<TEntity>
        where TEntityDto : IEntityDto
        where TGetConfigPagedInput : IOptionalTreePagedResultRequest
    {
        public AsyncPerTableOptionalTreeConfigurationAppService(IPerTableOptionalTreeRepository<TEntity> Repository) : base(Repository) { }
    }


    public abstract class AsyncPerTableOptionalTreeConfigurationAppService<TEntity, TEntityDto, TGetConfigPagedInput, TCreateInput, TUpdateByIdInput>
        : AsyncPerTableOptionalTreeConfigurationAppService<TEntity, TEntityDto, TGetConfigPagedInput, TCreateInput, TUpdateByIdInput, int>,
        IAsyncPerTableOptionalTreeConfigurationAppService<TEntityDto, TGetConfigPagedInput, TCreateInput, TUpdateByIdInput>
        where TEntity : class, ITreeEntity<TEntity>
        where TEntityDto : IEntityDto<int>
        where TGetConfigPagedInput : IOptionalTreePagedResultRequest
        where TUpdateByIdInput : IEntityDto<int>
    {
        public AsyncPerTableOptionalTreeConfigurationAppService(IPerTableOptionalTreeRepository<TEntity> Repository) : base(Repository) { }
    }


    public abstract class AsyncPerTableOptionalTreeConfigurationAppService<TEntity, TEntityDto, TGetConfigPagedInput, TCreateInput, TUpdateByIdInput, TPrimaryKey>
        : OptionalTreeConfigurationAppServiceBase<TEntity, TEntityDto, TGetConfigPagedInput, TCreateInput, TUpdateByIdInput, TPrimaryKey>,
        IAsyncPerTableOptionalTreeConfigurationAppService<TEntityDto, TGetConfigPagedInput, TCreateInput, TUpdateByIdInput, TPrimaryKey>
        where TEntity : class, ITreeEntity<TEntity, TPrimaryKey>
        where TEntityDto : IEntityDto<TPrimaryKey>
        where TGetConfigPagedInput : IOptionalTreePagedResultRequest
        where TUpdateByIdInput : IEntityDto<TPrimaryKey>
    {
        protected readonly IPerTableOptionalTreeRepository<TEntity, TPrimaryKey> _Repository;

        public AsyncPerTableOptionalTreeConfigurationAppService(IPerTableOptionalTreeRepository<TEntity, TPrimaryKey> Repository)
        {
            _Repository = Repository;
        }

        protected virtual bool GetSingleByIdEnabled { get; set; } = true;
        protected virtual bool CreateEnabled { get; set; } = true;
        protected virtual bool UpdateByIdEnabled { get; set; } = true;
        protected virtual bool DeleteByIdEnabled { get; set; } = true;
        protected virtual bool GetPagedEnabled { get; set; } = true;
        protected virtual bool GetAllEnabled { get; set; } = true;

        public virtual async Task<TEntityDto> GetSingleById(TPrimaryKey id)
        {
            if (!GetSingleByIdEnabled) { Forbidden(); }
            var entity = await GetEntityByIdAsync(id);
            return MapToEntityDto(entity);
        }

        public virtual async Task<TEntityDto> Create(TCreateInput input)
        {
            if (!CreateEnabled) { Forbidden(); }

            var entity = MapToEntity(input);
            await _Repository.InsertAsync(entity);
            await CurrentUnitOfWork.SaveChangesAsync();
            return MapToEntityDto(entity);
        }

        public virtual async Task<TEntityDto> UpdateById(TUpdateByIdInput input)
        {
            if (!UpdateByIdEnabled) { Forbidden(); }

            var entity = await GetEntityByIdAsync(input.Id);
            await _Repository.UpdateAsync(MapToEntity(input));
            CurrentUnitOfWork.SaveChanges();
            return MapToEntityDto(entity);
        }

        public virtual Task DeleteById(TPrimaryKey id)
        {
            if (!DeleteByIdEnabled) { Forbidden(); }

            return _Repository.DeleteAsync(id);
        }

        public virtual async Task<PagedResultDto<TEntityDto>> GetPaged(TGetConfigPagedInput input)
        {
            if (!GetPagedEnabled) { Forbidden(); }

            var query = _Repository.GetAll(input.TopOnly);
            var total = await _Repository.CountAsync(input.TopOnly);
            query = ApplySorting(query, input);
            query = ApplyPaging(query, input);
            var entities = await query.ToListAsync();
            return new PagedResultDto<TEntityDto>(total, entities.Select(MapToEntityDto).ToList());
        }

        public virtual async Task<IListResult<TEntityDto>> GetAll()
        {
            if (!GetAllEnabled) { Forbidden(); }

            var list = await _Repository.GetAllListAsync();
            return new ListResultDto<TEntityDto>(list.Select(MapToEntityDto).ToList());
        }


        protected virtual Task<TEntity> GetEntityByIdAsync(TPrimaryKey id)
        {
            return _Repository.GetAsync(id);
        }


    }

}
