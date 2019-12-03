using Abp.Domain.Repositories;
using RLCore.RLAppService.Lake.Dtos;
using RLCore.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.Lake
{
    public class LakeAppService : PagedResultAppService<RL.Lake, LakeOutput, int, GetInput>, ILakeAppService
    {
        public LakeAppService(IRepository<RL.Lake> repository)
           : base(repository)
        {

        }
    }
}
