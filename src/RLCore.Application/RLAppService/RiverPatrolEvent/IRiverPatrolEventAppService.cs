using RLCore.RLAppService.RiverPatrolEvent.Dtos;
using RLCore.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.RiverPatrolEvent
{
    public interface IRiverPatrolEventAppService
         : IJTAsyncCrudAppService<RiverPatrolEventOutput, int, GetPagedInput, CreateInput, UpdateByIdInput>
    {
    }
}
