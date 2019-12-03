using RLCore.RLAppService.Reservoir.Dtos;
using RLCore.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.Reservoir
{
    public interface IReservoirAppService : IPagedResultAppService<ReservoirOutput, int, GetInput>
    {
    }
}
