using Abp.Authorization;
using Abp.Domain.Repositories;
using RLCore.RLAppService.Wetland.Dtos;
using RLCore.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.Wetland
{
    [AbpAuthorize]
    public class WetlandAppService : PagedResultAppService<RL.Wetland, WetlandOutput, int, GetInput>, IWetlandAppService
    {
        public WetlandAppService(IRepository<RL.Wetland> repository)
           : base(repository)
        {

        }
    }
}
