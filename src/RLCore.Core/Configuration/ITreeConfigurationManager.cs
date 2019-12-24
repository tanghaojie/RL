using Abp.Dependency;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RLCore.Configuration
{
    public interface ITreeConfigurationManager : ISingletonDependency
    {
        Task<IList<TreeConfigDto>> GetAll(string configName);

        Task<TreeConfigDto> Get(int id);

        Task Delete(int id);

        Task<TreeConfigDto> Update(TreeConfigDto config, bool cascade = false);

        Task<TreeConfigDto> Add(string configName, TreeConfigDto config, int? parentId = null);

        Task<bool> NameExist(string configName, string name, int? parentId = null);

    }
}
