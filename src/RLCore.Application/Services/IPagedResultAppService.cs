using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.Services
{
    public interface IPagedResultAppService<TEntityDto, TPrimaryKey, in TGetInput>
        : IApplicationService
        where TEntityDto : IEntityDto<TPrimaryKey>
        where TGetInput : IPagedResultRequest
    {
        PagedResultDto<TEntityDto> Get(TGetInput input);
    }
}
