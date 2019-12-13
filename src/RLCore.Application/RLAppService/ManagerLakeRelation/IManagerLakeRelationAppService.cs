using RLCore.RLAppService.ManagerLakeRelation.Dtos;
using RLCore.Services;

namespace RLCore.RLAppService.ManagerLakeRelation
{
    public interface IManagerLakeRelationAppService
        : IJTAsyncCrudAppService<ManagerLakeRelationOutput, int, GetPagedInput, CreateInput, UpdateByIdInput>
    {
    }
}