using Microsoft.EntityFrameworkCore;
using RLCore.Configuration.Optional.Entities;
using RLCore.Configuration.Optional.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLCore.Configuration.Optional.Manager
{
    public class SingleTableOptionalTreeConfigurationManager : ISingleTableOptionalTreeConfigurationManager
    {
        private readonly ISingleTableOptionalTreeRepository _singleTableOptioanRepository;

        public SingleTableOptionalTreeConfigurationManager(ISingleTableOptionalTreeRepository singleTableOptioanRepository)
        {
            _singleTableOptioanRepository = singleTableOptioanRepository;
        }

        public IQueryable<SingleTableOptionalTree> GetAll(string optionType, bool topOnly = true)
        {
            return _singleTableOptioanRepository.GetAll().Where(u => u.OptionType == optionType && (topOnly ? u.Parent == null : true));
        }

        public async Task<IList<SingleTableOptionalTree>> GetAllAsync(string optionType, bool topOnly = true)
        {
            return await _singleTableOptioanRepository.GetAllListAsync(u => u.OptionType == optionType && (topOnly ? u.Parent == null : true));
        }


        public async Task<SingleTableOptionalTree> GetAsync(int id)
        {
            return await _singleTableOptioanRepository.GetAsync(id);
        }


        public async Task<SingleTableOptionalTree> AddAsync(string optionType, SingleTableOptionalTree entity)
        {
            entity.OptionType = optionType;
            var id = await _singleTableOptioanRepository.InsertAndGetIdAsync(entity);
            if (entity.Subs != null && entity.Subs.Count > 0)
            {
                foreach (var sub in entity.Subs)
                {
                    sub.ParentId = id;
                    await AddAsync(optionType, sub);
                }
            }
            return await GetAsync(id);
        }




        public async Task DeleteAsync(int id)
        {
            await _singleTableOptioanRepository.DeleteAsync(id);
        }





        public async Task<SingleTableOptionalTree> UpdateAsync(SingleTableOptionalTree entity)
        {
            var id = entity.Id;
            var inDb = await _singleTableOptioanRepository.GetAsync(id);
            inDb.Data = entity.Data;
            inDb.Description = entity.Description;
            inDb.Option = entity.Option;
            return await GetAsync(id);
        }




        public async Task<bool> NameExistAsync(string optionType, string name, int? parentId = null)
        {
            return await _singleTableOptioanRepository.CountAsync(u => u.OptionType == optionType && u.ParentId == parentId && u.Option == name) > 0;
        }

        public async Task<bool> ExistAsync(string optionType, int id)
        {
            return await _singleTableOptioanRepository.CountAsync(u => u.OptionType == optionType && u.Id == id) > 0;
        }

        public bool Exist(string optionType, int id)
        {
            return _singleTableOptioanRepository.Count(u => u.OptionType == optionType && u.Id == id) > 0;
        }




        public int Count(string optionType, bool topOnly = true)
        {
            var query = _singleTableOptioanRepository.GetAll().Where(u => u.OptionType == optionType && (topOnly ? u.Parent == null : true));
            return query.Count();
        }

        public async Task<int> CountAsync(string optionType, bool topOnly = true)
        {
            var query = _singleTableOptioanRepository.GetAll().Where(u => u.OptionType == optionType && (topOnly ? u.Parent == null : true));
            return await query.CountAsync();
        }

    }
}
