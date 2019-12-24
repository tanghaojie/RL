using Abp.Application.Services;
using Abp.Dependency;
using RLCore.RLAppService.RiverPatrol.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RLCore.RLAppService.RiverPatrol
{
    public interface IRiverPatrolAppService : IApplicationService, ITransientDependency
    {
        Task<int> Start(StartInput input);

        Task<RiverPatrolOutput> End(EndInput input);

        Task<RiverPatrolOutput> GetCurrent();

        Task UploadPoints(UploadPointsInput input);

        Task Delete(int id);
    }
}
