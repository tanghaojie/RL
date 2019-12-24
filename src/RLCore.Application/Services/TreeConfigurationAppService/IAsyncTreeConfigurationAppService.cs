using Abp.Application.Services;
using Abp.Application.Services.Dto;
using RLCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RLCore.Services
{
    public interface IAsyncTreeConfigurationAppService
     : IAsyncTreeConfigurationAppService<EntityDto<int>>
    { }

    public interface IAsyncTreeConfigurationAppService<TEntityDto>
       : IAsyncTreeConfigurationAppService<TEntityDto, ConfigPagedResultRequest>
       where TEntityDto : IEntityDto<int>
    { }

    public interface IAsyncTreeConfigurationAppService<TEntityDto, in TGetPagedInput>
       : IAsyncTreeConfigurationAppService<TEntityDto, TGetPagedInput, TEntityDto>
       where TEntityDto : IEntityDto<int>
        where TGetPagedInput : IConfigPagedResultRequest
    { }

    public interface IAsyncTreeConfigurationAppService<TEntityDto, in TGetPagedInput, in TCreateInput>
        : IAsyncTreeConfigurationAppService<TEntityDto, TGetPagedInput, TCreateInput, EntityDto<int>>
        where TEntityDto : IEntityDto<int>
        where TGetPagedInput : IConfigPagedResultRequest
    { }

    public interface IAsyncTreeConfigurationAppService<TEntityDto, in TGetPagedInput, in TCreateInput, in TUpdateByIdInput>
        : IApplicationService
        where TEntityDto : IEntityDto<int>
        where TGetPagedInput : IConfigPagedResultRequest
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
