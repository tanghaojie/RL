using RLCore.RLAppService.Configuration.RiverPatrolEventType.Dtos;
using RLCore.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.Configuration.RiverPatrolEventType
{
    public interface IRiverPatrolEventTypeConfigAppService
         : IAsyncTreeConfigurationAppService<RiverPatrolEventTypeOutput, GetPagedInput, CreateInput, UpdateByIdInput>
    {
    }
}
