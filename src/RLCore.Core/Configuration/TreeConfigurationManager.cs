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

        public IQueryable<TreeConfiguration> GetAll(string configName, bool topOnly = true)
        {
            return _ConfigRepository.GetAll().Where(u => u.ConfigName == configName && (topOnly ? u.Parent == null : true));
        }

        public async Task<IList<TreeConfiguration>> GetAllAsync(string configName, bool topOnly = true)
        {
            return await _ConfigRepository.GetAllListAsync(u => u.ConfigName == configName && (topOnly ? u.Parent == null : true));
        }


        public async Task<TreeConfiguration> GetAsync(int id)
        {
            return await _ConfigRepository.GetAsync(id);
        }




        public async Task<TreeConfiguration> AddAsync(string configName, TreeConfiguration entity)
        {
            entity.ConfigName = configName;
            var id = await _ConfigRepository.InsertAndGetIdAsync(entity);
            if (entity.Subs != null && entity.Subs.Count > 0)
            {
                foreach (var sub in entity.Subs)
                {
                    sub.ParentId = id;
                    await AddAsync(configName, sub);
                }
            }
            return await GetAsync(id);
        }




        public async Task DeleteAsync(int id)
        {
            await _ConfigRepository.DeleteAsync(id);
        }





        public async Task<TreeConfiguration> UpdateAsync(TreeConfiguration entity)
        {
            var id = entity.Id;
            var inDb = await _ConfigRepository.GetAsync(id);
            inDb.Data = entity.Data;
            inDb.Description = entity.Description;
            inDb.Name = entity.Name;
            return await GetAsync(id);
        }




        public async Task<bool> NameExistAsync(string configName, string name, int? parentId = null)
        {
            return await _ConfigRepository.CountAsync(u => u.ConfigName == configName && u.ParentId == parentId && u.Name == name) > 0;
        }

        public async Task<bool> ExistAsync(string configName, int id)
        {
            return await _ConfigRepository.CountAsync(u => u.ConfigName == configName && u.Id == id) > 0;
        }

        public bool Exist(string configName, int id)
        {
            return _ConfigRepository.Count(u => u.ConfigName == configName && u.Id == id) > 0;
        }




        public int Count(string configName, bool topOnly = true)
        {
            var query = _ConfigRepository.GetAll().Where(u => u.ConfigName == configName && (topOnly ? u.Parent == null : true));
            return query.Count();
        }

        public async Task<int> CountAsync(string configName, bool topOnly = true)
        {
            var query = _ConfigRepository.GetAll().Where(u => u.ConfigName == configName && (topOnly ? u.Parent == null : true));
            return await query.CountAsync();
        }



        //private IList<TreeConfigDto> MapWithoutParent(IList<TreeConfigEntity> entities)
        //{
        //    if (entities == null)
        //    {
        //        return null;
        //    }
        //    var len = entities.Count;
        //    if (len <= 0)
        //    {
        //        return new List<TreeConfigDto>();
        //    }
        //    var list = new List<TreeConfigDto>();
        //    foreach (var e in entities)
        //    {
        //        list.Add(MapWithoutParent(e));
        //    }
        //    return list;
        //}

        //private TreeConfigDto MapWithoutParent(TreeConfigEntity entity)
        //{
        //    if (entity == null)
        //    {
        //        return null;
        //    }
        //    return new TreeConfigDto
        //    {
        //        Id = entity.Id,
        //        CreationTime = entity.CreationTime,
        //        Data = entity.Data,
        //        Description = entity.Description,
        //        Name = entity.Name,
        //        //Parent = MappingTop(entity.Parent),
        //        Subs = MapWithoutParent(entity.Subs)
        //    };
        //}

    }
}
