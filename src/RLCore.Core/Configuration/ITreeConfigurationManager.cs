using Abp.Dependency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLCore.Configuration
{
    public interface ITreeConfigurationManager : ISingletonDependency
    {
        IQueryable<TreeConfiguration> GetAll(string configName, bool topOnly = true);
        Task<IList<TreeConfiguration>> GetAllAsync(string configName, bool topOnly = true);

        Task<TreeConfiguration> GetAsync(int id);

        Task DeleteAsync(int id);

        /// <summary>
        /// update self only, not update subs because of safty
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<TreeConfiguration> UpdateAsync(TreeConfiguration entity);

        Task<TreeConfiguration> AddAsync(string configName, TreeConfiguration entity);

        Task<bool> NameExistAsync(string configName, string name, int? parentId = null);

        Task<bool> ExistAsync(string configName, int id);

        bool Exist(string configName, int id);

        int Count(string configName, bool topOnly = true);

        Task<int> CountAsync(string configName, bool topOnly = true);

    }
}
