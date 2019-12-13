using Abp.Authorization;
using Abp.Domain.Repositories;
using RLCore.RLAppService.ManagerLakeRelation.Dtos;
using RLCore.Services;

namespace RLCore.RLAppService.ManagerLakeRelation
{
    [AbpAuthorize]
    public class ManagerLakeRelationAppService
        : JTAsyncCrudAppService<RL.ManagerLakeRelation, ManagerLakeRelationOutput, int, GetPagedInput, CreateInput, UpdateByIdInput>,
        IManagerLakeRelationAppService
    {
        public ManagerLakeRelationAppService(IRepository<RL.ManagerLakeRelation> repository)
            : base(repository)
        {
            UpdateByIdEnabled = false;
        }
    }
}
