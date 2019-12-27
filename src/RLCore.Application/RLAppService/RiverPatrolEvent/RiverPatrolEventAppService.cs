using Abp.Domain.Repositories;
using RLCore.Configuration;
using RLCore.Configuration.Optional.Manager;
using RLCore.RLAppService.RiverPatrolEvent.Dtos;
using RLCore.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.RiverPatrolEvent
{
    public class RiverPatrolEventAppService
        : JTAsyncCrudAppService<RL.RiverPatrolEvent, RiverPatrolEventOutput, int, GetPagedInput, CreateInput, UpdateByIdInput>,
        IRiverPatrolEventAppService
    {
        public RiverPatrolEventAppService(IRepository<RL.RiverPatrolEvent> repository)
            : base(repository)
        {
        }
    }
}
