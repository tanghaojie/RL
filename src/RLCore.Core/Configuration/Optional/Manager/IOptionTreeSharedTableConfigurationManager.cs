using Abp.Dependency;
using RLCore.Configuration.Optional.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLCore.Configuration.Optional.Manager
{
    /// <summary>
    /// Single Table Optional Tree Configuration Manager Use For "Wrap" Different OptionType
    /// Per Table Option Tree Do not Need
    /// </summary>
    public interface IOptionTreeSharedTableConfigurationManager : ISingletonDependency
    {
        IQueryable<OptionTreeSharedTable> GetAll(string optionType, bool topOnly = true);
        Task<IList<OptionTreeSharedTable>> GetAllAsync(string optionType, bool topOnly = true);

        Task<OptionTreeSharedTable> GetAsync(int id);

        Task DeleteAsync(int id);

        /// <summary>
        /// update self only, not update subs because of safty
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<OptionTreeSharedTable> UpdateAsync(OptionTreeSharedTable entity);

        Task<OptionTreeSharedTable> AddAsync(string optionType, OptionTreeSharedTable entity);

        Task<bool> NameExistAsync(string optionType, string name, int? parentId = null);

        Task<bool> ExistAsync(string optionType, int id);

        bool Exist(string optionType, int id);

        int Count(string optionType, bool topOnly = true);

        Task<int> CountAsync(string optionType, bool topOnly = true);

    }
}
