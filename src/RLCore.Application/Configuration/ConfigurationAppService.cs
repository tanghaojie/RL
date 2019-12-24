using Abp.Domain.Repositories;
using Abp.UI;
using RLCore.Configuration.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLCore.Configuration
{
    public class ConfigurationAppService : RLCoreAppServiceBase, IConfigurationAppService
    {
        private readonly ITreeConfigurationManager _treeConfigurationManager;

        public const string River_Patrol_Event_Type = "RiverPatrolEventType";

        public ConfigurationAppService(
            ITreeConfigurationManager treeConfigurationManager
            )
        {
            _treeConfigurationManager = treeConfigurationManager;
        }

        public async Task<RiverPatrolEventTypeOutput> AddRiverPatrolEventType(AddRiverPatrolEventTypeInput input)
        {
            var name = input.Name;
            var pId = input.ParentId;
            if (await _treeConfigurationManager.NameExist(River_Patrol_Event_Type, name, pId))
            {
                throw new UserFriendlyException("Exist");
            }

            return ObjectMapper.Map<RiverPatrolEventTypeOutput>(
                await _treeConfigurationManager.Add(
                    River_Patrol_Event_Type,
                    new TreeConfigDto
                    {
                        Data = input.Data,
                        Description = input.Description,
                        Name = name,
                    },
                    pId)
                );
        }

        public async Task<IList<RiverPatrolEventTypeOutput>> GetAllRiverPatrolEventType()
        {
            return ObjectMapper.Map<IList<RiverPatrolEventTypeOutput>>(await _treeConfigurationManager.GetAll(River_Patrol_Event_Type));
        }

        public async Task Delete(int id)
        {
            await _treeConfigurationManager.Delete(id);
        }

    }
}
