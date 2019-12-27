using RLCore.RLAppService.Configuration.RiverPatrolEventSourceType.Dtos;
using RLCore.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.Configuration.RiverPatrolEventSourceType
{
    public interface IRiverPatrolEventSourceTypeAppService 
        : IAsyncOptionTreeConfigurationAppService<RiverPatrolEventSourceTypeOutput, GetPagedInput, CreateInput, UpdateByIdInput>
    {
        
    }
}
