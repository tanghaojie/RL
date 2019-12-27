using Abp.UI;
using RLCore.Configuration;
using RLCore.Configuration.Optional.Manager;
using RLCore.RLAppService.Configuration.RiverPatrolEventType.Dtos;
using RLCore.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RLCore.RLAppService.Configuration.RiverPatrolEventType
{
    public class RiverPatrolEventTypeConfigAppService :
        AsyncSingleTableOptionalTreeConfigurationAppService<RiverPatrolEventTypeOutput, GetPagedInput, CreateInput, UpdateByIdInput>,
        IRiverPatrolEventTypeConfigAppService
    {
        public override string ConfigurationName { get; set; } = RLCoreConsts.Configuraton_River_Patrol_Event_Type;

        public RiverPatrolEventTypeConfigAppService(ISingleTableOptionalTreeConfigurationManager treeConfigurationManager) : base(treeConfigurationManager)
        {
            UpdateByIdEnabled = false;
        }

        public override async Task<RiverPatrolEventTypeOutput> Create(CreateInput input)
        {
            var name = input.Option;
            var pId = input.ParentId;
            if (await _treeConfigurationManager.NameExistAsync(RLCoreConsts.Configuraton_River_Patrol_Event_Type, name, pId))
            {
                throw new UserFriendlyException("Exist");
            }
            return await base.Create(input);
        }
    }
}
