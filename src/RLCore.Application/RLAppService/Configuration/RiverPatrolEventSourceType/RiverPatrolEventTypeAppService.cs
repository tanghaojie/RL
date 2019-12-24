using Abp.UI;
using RLCore.Configuration;
using RLCore.RLAppService.Configuration.RiverPatrolEventSourceType.Dtos;
using RLCore.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RLCore.RLAppService.Configuration.RiverPatrolEventSourceType
{
    public class RiverPatrolEventSourceTypeConfigAppService :
        AsyncTreeConfigurationAppService<RiverPatrolEventSourceTypeOutput, GetPagedInput, CreateInput, UpdateByIdInput>,
        IRiverPatrolEventSourceTypeConfigAppService
    {
        public override string ConfigurationName { get; set; } = RLCoreConsts.Configuraton_River_Patrol_Event_Source_Type;

        public RiverPatrolEventSourceTypeConfigAppService(ITreeConfigurationManager treeConfigurationManager) : base(treeConfigurationManager)
        {
            UpdateByIdEnabled = false;
        }

        public override async Task<RiverPatrolEventSourceTypeOutput> Create(CreateInput input)
        {
            var name = input.Name;
            if (await _treeConfigurationManager.NameExistAsync(RLCoreConsts.Configuraton_River_Patrol_Event_Type, name))
            {
                throw new UserFriendlyException("Exist");
            }
            return await base.Create(input);
        }
    }
}
