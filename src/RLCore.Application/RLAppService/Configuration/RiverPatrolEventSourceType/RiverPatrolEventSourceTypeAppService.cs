using Abp.UI;
using RLCore.Configuration.Optional.Repository;
using RLCore.RLAppService.Configuration.RiverPatrolEventSourceType.Dtos;
using RLCore.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RLCore.RLAppService.Configuration.RiverPatrolEventSourceType
{
    public class RiverPatrolEventSourceTypeAppService
        : AsyncOptionTreeConfigurationAppService<RL.RiverPatrolEventSourceType, RiverPatrolEventSourceTypeOutput, GetPagedInput, CreateInput, UpdateByIdInput>,
        IRiverPatrolEventSourceTypeAppService
    {
        public RiverPatrolEventSourceTypeAppService(IOptionTreeRepository<RL.RiverPatrolEventSourceType> Repository) : base(Repository)
        {

        }

        public override async Task<RiverPatrolEventSourceTypeOutput> Create(CreateInput input)
        {
            if (await _Repository.CountAsync(x => x.Option == input.Option) > 0)
            {
                throw new UserFriendlyException("Exist");
            }
            return await base.Create(input);
        }
    }
}
