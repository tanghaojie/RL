using Abp.Application.Services;
using Abp.Domain.Repositories;
using RLCore.RLAppService.ManagerLakeRelation.Dtos;
using RLCore.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RLCore.RLAppService.ManagerLakeRelation
{
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
