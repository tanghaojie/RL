using RLCore.RLAppService.Wetland.Dtos;
using RLCore.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.Wetland
{
    public interface IWetlandAppService : IPagedResultAppService<WetlandOutput, int, GetInput>
    {
    }
}
