using Abp.Application.Services;
using Abp.Application.Services.Dto;
using RLCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RLCore.Services
{
    public interface IAsyncSingleTableOptionalTreeConfigurationAppService
     : IAsyncSingleTableOptionalTreeConfigurationAppService<EntityDto<int>>
    { }

    public interface IAsyncSingleTableOptionalTreeConfigurationAppService<TEntityDto>
       : IAsyncSingleTableOptionalTreeConfigurationAppService<TEntityDto, OptionalTreePagedResultRequest>
       where TEntityDto : IEntityDto<int>
    { }

    public interface IAsyncSingleTableOptionalTreeConfigurationAppService<TEntityDto, in TGetPagedInput>
       : IAsyncSingleTableOptionalTreeConfigurationAppService<TEntityDto, TGetPagedInput, TEntityDto>
       where TEntityDto : IEntityDto<int>
        where TGetPagedInput : IOptionalTreePagedResultRequest
    { }

    public interface IAsyncSingleTableOptionalTreeConfigurationAppService<TEntityDto, in TGetPagedInput, in TCreateInput>
        : IAsyncSingleTableOptionalTreeConfigurationAppService<TEntityDto, TGetPagedInput, TCreateInput, EntityDto<int>>
        where TEntityDto : IEntityDto<int>
        where TGetPagedInput : IOptionalTreePagedResultRequest
    { }

    public interface IAsyncSingleTableOptionalTreeConfigurationAppService<TEntityDto, in TGetPagedInput, in TCreateInput, in TUpdateByIdInput>
        : IApplicationService
        where TEntityDto : IEntityDto<int>
        where TGetPagedInput : IOptionalTreePagedResultRequest
        where TUpdateByIdInput : IEntityDto<int>
    {
        Task<TEntityDto> GetSingleById(int id);
        Task<TEntityDto> Create(TCreateInput input);
        Task<TEntityDto> UpdateById(TUpdateByIdInput input);
        Task DeleteById(int id);
        Task<PagedResultDto<TEntityDto>> GetPaged(TGetPagedInput input);
        Task<IListResult<TEntityDto>> GetAll();
    }
}
