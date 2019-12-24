using RLCore.RLAppService.Configuration.RiverPatrolEventType.Dtos;
using RLCore.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.Configuration.RiverPatrolEventType
{
    public interface IRiverPatrolEventTypeAppService
         : IAsyncTreeConfigurationAppService<RiverPatrolEventTypeOutput, GetPagedInput, CreateInput, UpdateByIdInput>
    {
    }
}
