using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace RLCore.Services
{
    public abstract class JTAsyncCrudAppService<TEntity, TEntityDto>
        : JTAsyncCrudAppService<TEntity, TEntityDto, int>
        where TEntity : class, IEntity<int>
        where TEntityDto : IEntityDto<int>
    {
        protected JTAsyncCrudAppService(IRepository<TEntity, int> repository)
            : base(repository)
        { }
    }

    public abstract class JTAsyncCrudAppService<TEntity, TEntityDto, TPrimaryKey>
        : JTAsyncCrudAppService<TEntity, TEntityDto, TPrimaryKey, PagedAndSortedResultRequestDto>
        where TEntity : class, IEntity<TPrimaryKey>
        where TEntityDto : IEntityDto<TPrimaryKey>
    {
        protected JTAsyncCrudAppService(IRepository<TEntity, TPrimaryKey> repository)
            : base(repository)
        { }
    }

    public abstract class JTAsyncCrudAppService<TEntity, TEntityDto, TPrimaryKey, TGetPagedInput>
        : JTAsyncCrudAppService<TEntity, TEntityDto, TPrimaryKey, TGetPagedInput, EntityDto<TPrimaryKey>>
        where TEntity : class, IEntity<TPrimaryKey>
        where TEntityDto : IEntityDto<TPrimaryKey>
        where TGetPagedInput : IPagedResultRequest
    {
        protected JTAsyncCrudAppService(IRepository<TEntity, TPrimaryKey> repository)
            : base(repository)
        { }
    }

    public abstract class JTAsyncCrudAppService<TEntity, TEntityDto, TPrimaryKey, TGetPagedInput, TCreateInput>
        : JTAsyncCrudAppService<TEntity, TEntityDto, TPrimaryKey, TGetPagedInput, TCreateInput, EntityDto<TPrimaryKey>>
        where TEntity : class, IEntity<TPrimaryKey>
        where TEntityDto : IEntityDto<TPrimaryKey>
        where TGetPagedInput : IPagedResultRequest
    {
        protected JTAsyncCrudAppService(IRepository<TEntity, TPrimaryKey> repository)
            : base(repository)
        { }
    }

    public abstract class JTAsyncCrudAppService<TEntity, TEntityDto, TPrimaryKey, TGetPagedInput, TCreateInput, TUpdateByIdInput>
        : JTCrudAppServiceBase<TEntity, TEntityDto, TPrimaryKey, TGetPagedInput, TCreateInput, TUpdateByIdInput>,
        IJTAsyncCrudAppService<TEntityDto, TPrimaryKey, TGetPagedInput, TCreateInput, TUpdateByIdInput>
        where TEntity : class, IEntity<TPrimaryKey>
        where TEntityDto : IEntityDto<TPrimaryKey>
        where TGetPagedInput : IPagedResultRequest
        where TUpdateByIdInput : IEntityDto<TPrimaryKey>
    {
        protected JTAsyncCrudAppService(IRepository<TEntity, TPrimaryKey> repository)
           : base(repository)
        { }

        protected virtual bool GetSingleByIdEnabled { get; set; } = true;
        protected virtual bool CreateEnabled { get; set; } = true;
        protected virtual bool UpdateByIdEnabled { get; set; } = true;
        protected virtual bool DeleteByIdEnabled { get; set; } = true;
        protected virtual bool GetPagedEnabled { get; set; } = true;

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
            await Repository.InsertAsync(entity);
            await CurrentUnitOfWork.SaveChangesAsync();
            return MapToEntityDto(entity);
        }

        public virtual async Task<TEntityDto> UpdateById(TUpdateByIdInput input)
        {
            if (!UpdateByIdEnabled) { Forbidden(); }

            var entity = await GetEntityByIdAsync(input.Id);
            MapToEntity(input, entity);
            CurrentUnitOfWork.SaveChanges();
            return MapToEntityDto(entity);
        }

        public virtual Task DeleteById(TPrimaryKey id)
        {
            if (!DeleteByIdEnabled) { Forbidden(); }

            return Repository.DeleteAsync(id);
        }

        public virtual async Task<PagedResultDto<TEntityDto>> GetPaged(TGetPagedInput input)
        {
            if (!GetPagedEnabled) { Forbidden(); }

            var query = Repository.GetAll();
            var total = await query.CountAsync();
            query = ApplySorting(query, input);
            query = ApplyPaging(query, input);
            var entities = await query.ToListAsync();
            return new PagedResultDto<TEntityDto>(total, entities.Select(MapToEntityDto).ToList());
        }

        protected virtual Task<TEntity> GetEntityByIdAsync(TPrimaryKey id)
        {
            return Repository.GetAsync(id);
        }
    }
}
