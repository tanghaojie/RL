//using Abp.Domain.Repositories;
//using Microsoft.EntityFrameworkCore;
//using RLCore.Configuration.Optional.Entity;
//using RLCore.Repositories;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace RLCore.Configuration
//{
//    public class OptionalConfigurationManager : IOptionalConfigurationManager
//    {
//        private readonly IConfigRepository _ConfigRepository;

//        public OptionalConfigurationManager(IConfigRepository ConfigRepository)
//        {
//            _ConfigRepository = ConfigRepository;
//        }

//        public IQueryable<SingleTableOptionalTree> GetAll(string configName, bool topOnly = true)
//        {
//            return _ConfigRepository.GetAll().Where(u => u.OptionType == configName && (topOnly ? u.Parent == null : true));
//        }

//        public async Task<IList<SingleTableOptionalTree>> GetAllAsync(string configName, bool topOnly = true)
//        {
//            return await _ConfigRepository.GetAllListAsync(u => u.OptionType == configName && (topOnly ? u.Parent == null : true));
//        }


//        public async Task<SingleTableOptionalTree> GetAsync(int id)
//        {
//            return await _ConfigRepository.GetAsync(id);
//        }




//        public async Task<SingleTableOptionalTree> AddAsync(string configName, SingleTableOptionalTree entity)
//        {
//            entity.OptionType = configName;
//            var id = await _ConfigRepository.InsertAndGetIdAsync(entity);
//            if (entity.Subs != null && entity.Subs.Count > 0)
//            {
//                foreach (var sub in entity.Subs)
//                {
//                    sub.ParentId = id;
//                    await AddAsync(configName, sub);
//                }
//            }
//            return await GetAsync(id);
//        }




//        public async Task DeleteAsync(int id)
//        {
//            await _ConfigRepository.DeleteAsync(id);
//        }





//        public async Task<SingleTableOptionalTree> UpdateAsync(SingleTableOptionalTree entity)
//        {
//            var id = entity.Id;
//            var inDb = await _ConfigRepository.GetAsync(id);
//            inDb.Data = entity.Data;
//            inDb.Description = entity.Description;
//            inDb.Option = entity.Option;
//            return await GetAsync(id);
//        }




//        public async Task<bool> NameExistAsync(string configName, string name, int? parentId = null)
//        {
//            return await _ConfigRepository.CountAsync(u => u.OptionType == configName && u.ParentId == parentId && u.Option == name) > 0;
//        }

//        public async Task<bool> ExistAsync(string configName, int id)
//        {
//            return await _ConfigRepository.CountAsync(u => u.OptionType == configName && u.Id == id) > 0;
//        }

//        public bool Exist(string configName, int id)
//        {
//            return _ConfigRepository.Count(u => u.OptionType == configName && u.Id == id) > 0;
//        }




//        public int Count(string configName, bool topOnly = true)
//        {
//            var query = _ConfigRepository.GetAll().Where(u => u.OptionType == configName && (topOnly ? u.Parent == null : true));
//            return query.Count();
//        }

//        public async Task<int> CountAsync(string configName, bool topOnly = true)
//        {
//            var query = _ConfigRepository.GetAll().Where(u => u.OptionType == configName && (topOnly ? u.Parent == null : true));
//            return await query.CountAsync();
//        }



//        //private IList<TreeConfigDto> MapWithoutParent(IList<TreeConfigEntity> entities)
//        //{
//        //    if (entities == null)
//        //    {
//        //        return null;
//        //    }
//        //    var len = entities.Count;
//        //    if (len <= 0)
//        //    {
//        //        return new List<TreeConfigDto>();
//        //    }
//        //    var list = new List<TreeConfigDto>();
//        //    foreach (var e in entities)
//        //    {
//        //        list.Add(MapWithoutParent(e));
//        //    }
//        //    return list;
//        //}

//        //private TreeConfigDto MapWithoutParent(TreeConfigEntity entity)
//        //{
//        //    if (entity == null)
//        //    {
//        //        return null;
//        //    }
//        //    return new TreeConfigDto
//        //    {
//        //        Id = entity.Id,
//        //        CreationTime = entity.CreationTime,
//        //        Data = entity.Data,
//        //        Description = entity.Description,
//        //        Name = entity.Name,
//        //        //Parent = MappingTop(entity.Parent),
//        //        Subs = MapWithoutParent(entity.Subs)
//        //    };
//        //}

//    }
//}
