using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System.Threading.Tasks;
namespace RLCore.Services
{
    public interface IJTAsyncCrudAppService
       : IJTAsyncCrudAppService<EntityDto<int>>
    { }

    public interface IJTAsyncCrudAppService<TEntityDto>
       : IJTAsyncCrudAppService<TEntityDto, int>
       where TEntityDto : IEntityDto<int>
    { }

    public interface IJTAsyncCrudAppService<TEntityDto, TPrimaryKey>
       : IJTAsyncCrudAppService<TEntityDto, TPrimaryKey, PagedAndSortedResultRequestDto>
       where TEntityDto : IEntityDto<TPrimaryKey>
    { }

    public interface IJTAsyncCrudAppService<TEntityDto, TPrimaryKey, in TGetPagedInput>
       : IJTAsyncCrudAppService<TEntityDto, TPrimaryKey, TGetPagedInput, TEntityDto>
       where TEntityDto : IEntityDto<TPrimaryKey>
        where TGetPagedInput : IPagedResultRequest
    { }

    public interface IJTAsyncCrudAppService<TEntityDto, TPrimaryKey, in TGetPagedInput, in TCreateInput>
        : IJTAsyncCrudAppService<TEntityDto, TPrimaryKey, TGetPagedInput, TCreateInput, EntityDto<TPrimaryKey>>
        where TEntityDto : IEntityDto<TPrimaryKey>
        where TGetPagedInput : IPagedResultRequest
    { }

    public interface IJTAsyncCrudAppService<TEntityDto, TPrimaryKey, in TGetPagedInput, in TCreateInput, in TUpdateByIdInput>
        : IApplicationService
        where TEntityDto : IEntityDto<TPrimaryKey>
        where TGetPagedInput : IPagedResultRequest
        where TUpdateByIdInput : IEntityDto<TPrimaryKey>
    {
        Task<TEntityDto> GetSingleById(TPrimaryKey id);
        Task<TEntityDto> Create(TCreateInput input);
        Task<TEntityDto> UpdateById(TUpdateByIdInput input);
        Task DeleteById(TPrimaryKey id);
        Task<PagedResultDto<TEntityDto>> GetPaged(TGetPagedInput input);
    }
}
