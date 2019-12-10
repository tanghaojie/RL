using Abp.Application.Services;
using RLCore.RLAppService.ManagerLakeRelation.Dtos;
using RLCore.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.ManagerLakeRelation
{
    public interface IManagerLakeRelationAppService
        : IJTAsyncCrudAppService<ManagerLakeRelationOutput, int, GetPagedInput, CreateInput, UpdateByIdInput>
    {
    }
}
