using Abp.UI;
using RLCore.Configuration.Optional.Repository;
using RLCore.RLAppService.Configuration.RiverPatrolEventLevel.Dtos;
using RLCore.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RLCore.RLAppService.Configuration.RiverPatrolEventLevel
{
    public class RiverPatrolEventSourceLevelAppService
        : AsyncOptionTreeConfigurationAppService<RL.RiverPatrolEventLevel, RiverPatrolEventLevelOutput, GetPagedInput, CreateInput, UpdateByIdInput>,
        IRiverPatrolEventSourceLevelAppService
    {
        public RiverPatrolEventSourceLevelAppService(IOptionTreeRepository<RL.RiverPatrolEventLevel> Repository) : base(Repository)
        {

        }

        public override async Task<RiverPatrolEventLevelOutput> Create(CreateInput input)
        {
            if (await _Repository.CountAsync(x => x.Option == input.Option) > 0)
            {
                throw new UserFriendlyException("Exist");
            }
            return await base.Create(input);
        }
    }
}
