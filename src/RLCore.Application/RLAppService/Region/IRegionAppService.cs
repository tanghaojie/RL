using RLCore.RLAppService.Region.Dtos;
using RLCore.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.Region
{
    public interface IRegionAppService : IPagedResultAppService<RegionOutput, int, GetInput>
    {
    }
}
