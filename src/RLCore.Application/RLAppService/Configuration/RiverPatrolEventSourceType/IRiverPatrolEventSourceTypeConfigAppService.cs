using RLCore.RLAppService.Configuration.RiverPatrolEventSourceType.Dtos;
using RLCore.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.Configuration.RiverPatrolEventSourceType
{
    public interface IRiverPatrolEventSourceTypeConfigAppService
         : IAsyncTreeConfigurationAppService<RiverPatrolEventSourceTypeOutput, GetPagedInput, CreateInput, UpdateByIdInput>
    {
    }
}
