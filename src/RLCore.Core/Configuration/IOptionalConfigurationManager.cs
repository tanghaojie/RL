//using Abp.Dependency;
//using RLCore.Configuration.Optional.Entity;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace RLCore.Configuration
//{
//    public interface IOptionalConfigurationManager : ISingletonDependency
//    {
//        IQueryable<SingleTableOptionalTree> GetAll(string configName, bool topOnly = true);
//        Task<IList<SingleTableOptionalTree>> GetAllAsync(string configName, bool topOnly = true);

//        Task<SingleTableOptionalTree> GetAsync(int id);

//        Task DeleteAsync(int id);

//        /// <summary>
//        /// update self only, not update subs because of safty
//        /// </summary>
//        /// <param name="entity"></param>
//        /// <returns></returns>
//        Task<SingleTableOptionalTree> UpdateAsync(SingleTableOptionalTree entity);

//        Task<SingleTableOptionalTree> AddAsync(string configName, SingleTableOptionalTree entity);

//        Task<bool> NameExistAsync(string configName, string name, int? parentId = null);

//        Task<bool> ExistAsync(string configName, int id);

//        bool Exist(string configName, int id);

//        int Count(string configName, bool topOnly = true);

//        Task<int> CountAsync(string configName, bool topOnly = true);

//    }
//}
