using Abp.UI;
using RLCore.Configuration;
using RLCore.RLAppService.Configuration.RiverPatrolEventType.Dtos;
using RLCore.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RLCore.RLAppService.Configuration.RiverPatrolEventType
{
    public class RiverPatrolEventTypeAppService :
        AsyncTreeConfigurationAppService<RiverPatrolEventTypeOutput, GetPagedInput, CreateInput, UpdateByIdInput>,
        IRiverPatrolEventTypeAppService
    {
        public override string ConfigurationName { get; set; } = RLCoreConsts.Configuraton_River_Patrol_Event_Type;

        public RiverPatrolEventTypeAppService(ITreeConfigurationManager treeConfigurationManager) : base(treeConfigurationManager)
        {
            UpdateByIdEnabled = false;
        }

        public override async Task<RiverPatrolEventTypeOutput> Create(CreateInput input)
        {
            var name = input.Name;
            var pId = input.ParentId;
            if (await _treeConfigurationManager.NameExistAsync(RLCoreConsts.Configuraton_River_Patrol_Event_Type, name, pId))
            {
                throw new UserFriendlyException("Exist");
            }
            return await base.Create(input);
        }
    }
}
