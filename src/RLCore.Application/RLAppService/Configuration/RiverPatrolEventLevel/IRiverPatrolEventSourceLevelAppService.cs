using RLCore.RLAppService.Configuration.RiverPatrolEventLevel.Dtos;
using RLCore.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.Configuration.RiverPatrolEventLevel
{
    public interface IRiverPatrolEventSourceLevelAppService 
        : IAsyncOptionTreeConfigurationAppService<RiverPatrolEventLevelOutput, GetPagedInput, CreateInput, UpdateByIdInput>
    {
        
    }
}
