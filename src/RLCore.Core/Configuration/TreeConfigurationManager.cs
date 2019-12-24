using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using RLCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLCore.Configuration
{
    public class TreeConfigurationManager : ITreeConfigurationManager
    {
        private readonly IConfigRepository _ConfigRepository;

        public TreeConfigurationManager(IConfigRepository ConfigRepository)
        {
            _ConfigRepository = ConfigRepository;
        }



        public async Task<TreeConfigDto> Add(string configName, TreeConfigDto config, int? parentId = null)
        {
            var id = await _ConfigRepository.InsertAndGetIdAsync(new TreeConfigEntity
            {
                ConfigName = configName,
                CreationTime = config.CreationTime,
                Data = config.Data,
                Description = config.Description,
                Name = config.Name,
                ParentId = parentId,
            });
            if (config.Subs != null && config.Subs.Count > 0)
            {
                foreach (var sub in config.Subs)
                {
                    await Add(configName, sub, id);
                }
            }
            return await Get(id);
        }

        public async Task Delete(int id)
        {
            await _ConfigRepository.DeleteAsync(id);
        }

        public async Task<TreeConfigDto> Get(int id)
        {
            return MapWithoutParent(await _ConfigRepository.GetAsync(id));
        }

        public async Task<IList<TreeConfigDto>> GetAll(string configName)
        {
            var xx = await _ConfigRepository.GetAllListAsync(u => u.ConfigName == configName && u.Parent == null);

            return MapWithoutParent(xx);
        }

        public async Task<TreeConfigDto> Update(TreeConfigDto config, bool cascade = false)
        {
            var id = config.Id;
            var entity = await _ConfigRepository.GetAsync(id);
            entity.Data = config.Data;
            entity.Description = config.Description;
            entity.Name = config.Name;
            //entity.ParentId = config.Parent?.Id;
            if (cascade && config.Subs != null && config.Subs.Count > 0)
            {
                foreach (var sub in config.Subs)
                {
                    await Update(sub, cascade);
                }
            }
            return await Get(id);
        }

        public async Task<bool> NameExist(string configName, string name, int? parentId = null)
        {
            return await _ConfigRepository.CountAsync(u => u.ConfigName == configName && u.ParentId == parentId && u.Name == name) > 0;
        }



        private IList<TreeConfigDto> MapWithoutParent(IList<TreeConfigEntity> entities)
        {
            if (entities == null)
            {
                return null;
            }
            var len = entities.Count;
            if (len <= 0)
            {
                return new List<TreeConfigDto>();
            }
            var list = new List<TreeConfigDto>();
            foreach (var e in entities)
            {
                list.Add(MapWithoutParent(e));
            }
            return list;
        }

        private TreeConfigDto MapWithoutParent(TreeConfigEntity entity)
        {
            if (entity == null)
            {
                return null;
            }
            return new TreeConfigDto
            {
                Id = entity.Id,
                CreationTime = entity.CreationTime,
                Data = entity.Data,
                Description = entity.Description,
                Name = entity.Name,
                //Parent = MappingTop(entity.Parent),
                Subs = MapWithoutParent(entity.Subs)
            };
        }

    }
}
