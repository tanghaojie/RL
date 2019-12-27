using Abp.UI;
using RLCore.Configuration;
using RLCore.Configuration.Optional.Manager;
using RLCore.Configuration.Optional.Repository;
using RLCore.RLAppService.Configuration.RiverPatrolEventType.Dtos;
using RLCore.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RLCore.RLAppService.Configuration.RiverPatrolEventType
{
    public class RiverPatrolEventTypeAppService :
        AsyncOptionTreeConfigurationAppService<RL.RiverPatrolEventType, RiverPatrolEventTypeOutput, GetPagedInput, CreateInput, UpdateByIdInput>,
        IRiverPatrolEventTypeAppService
    {
        public RiverPatrolEventTypeAppService(IOptionTreeRepository<RL.RiverPatrolEventType> Repository) : base(Repository)
        {
            UpdateByIdEnabled = false;
        }

        public override async Task<RiverPatrolEventTypeOutput> Create(CreateInput input)
        {
            if (await _Repository.CountAsync(x => x.Option == input.Option && x.ParentId == input.ParentId) > 0)
            {
                throw new UserFriendlyException("Exist");
            }
            return await base.Create(input);
        }
    }
}
