using Abp.Authorization;
using Abp.Domain.Repositories;
using RLCore.RLAppService.Region.Dtos;
using RLCore.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.Region
{
    [AbpAuthorize]
    public class RegionAppService : PagedResultAppService<RL.Region, RegionOutput, int, GetInput>, IRegionAppService
    {
        public RegionAppService(IRepository<RL.Region> repository)
           : base(repository)
        {
        
        }
    }
}
