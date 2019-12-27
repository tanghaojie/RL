using RLCore.Configuration.Optional.Repository;
using RLCore.RLAppService.Configuration.RiverPatrolEventSourceType.Dtos;
using RLCore.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.Configuration.RiverPatrolEventSourceType
{
    public class ConfigRiverPatrolEventSourceTypeAppService
        : AsyncPerTableOptionalTreeConfigurationAppService<RL.RiverPatrolEventSourceType, RiverPatrolEventSourceTypeOutput, GetPagedInput, CreateInput, UpdateByIdInput>,
        IConfigRiverPatrolEventSourceTypeAppService
    {
        public ConfigRiverPatrolEventSourceTypeAppService(IPerTableOptionalTreeRepository<RL.RiverPatrolEventSourceType> Repository) : base(Repository)
        {
            
        }

    
    }
}
