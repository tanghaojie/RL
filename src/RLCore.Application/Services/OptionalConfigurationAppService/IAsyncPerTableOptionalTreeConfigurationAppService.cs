using Abp.Application.Services;
using Abp.Application.Services.Dto;
using RLCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RLCore.Services
{
    public interface IAsyncPerTableOptionalTreeConfigurationAppService
    : IAsyncPerTableOptionalTreeConfigurationAppService<EntityDto<int>>
    { }

    public interface IAsyncPerTableOptionalTreeConfigurationAppService<TEntityDto>
       : IAsyncPerTableOptionalTreeConfigurationAppService<TEntityDto, OptionalTreePagedResultRequest>
       where TEntityDto : IEntityDto<int>
    { }

    public interface IAsyncPerTableOptionalTreeConfigurationAppService<TEntityDto, in TGetPagedInput>
       : IAsyncPerTableOptionalTreeConfigurationAppService<TEntityDto, TGetPagedInput, TEntityDto>
       where TEntityDto : IEntityDto<int>
        where TGetPagedInput : IOptionalTreePagedResultRequest
    { }

    public interface IAsyncPerTableOptionalTreeConfigurationAppService<TEntityDto, in TGetPagedInput, in TCreateInput>
        : IAsyncPerTableOptionalTreeConfigurationAppService<TEntityDto, TGetPagedInput, TCreateInput, EntityDto<int>>
        where TEntityDto : IEntityDto<int>
        where TGetPagedInput : IOptionalTreePagedResultRequest
    { }

    public interface IAsyncPerTableOptionalTreeConfigurationAppService<TEntityDto, in TGetPagedInput, in TCreateInput, in TUpdateByIdInput>
       : IAsyncPerTableOptionalTreeConfigurationAppService<TEntityDto, TGetPagedInput, TCreateInput, TUpdateByIdInput, int>
       where TEntityDto : IEntityDto<int>
       where TGetPagedInput : IOptionalTreePagedResultRequest
       where TUpdateByIdInput : IEntityDto<int>
    { }

    public interface IAsyncPerTableOptionalTreeConfigurationAppService<TEntityDto, in TGetPagedInput, in TCreateInput, in TUpdateByIdInput, TPrimaryKey>
        : IApplicationService
        where TEntityDto : IEntityDto<TPrimaryKey>
        where TGetPagedInput : IOptionalTreePagedResultRequest
        where TUpdateByIdInput : IEntityDto<TPrimaryKey>
    {
        Task<TEntityDto> GetSingleById(TPrimaryKey id);
        Task<TEntityDto> Create(TCreateInput input);
        Task<TEntityDto> UpdateById(TUpdateByIdInput input);
        Task DeleteById(TPrimaryKey id);
        Task<PagedResultDto<TEntityDto>> GetPaged(TGetPagedInput input);
        Task<IListResult<TEntityDto>> GetAll();
    }
}
