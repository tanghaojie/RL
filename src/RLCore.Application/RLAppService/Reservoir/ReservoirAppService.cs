using Abp.Domain.Repositories;
using RLCore.RLAppService.Reservoir.Dtos;
using RLCore.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.Reservoir
{
    public class ReservoirAppService : PagedResultAppService<RL.Reservoir, ReservoirOutput, int, GetInput>, IReservoirAppService
    {
        public ReservoirAppService(IRepository<RL.Reservoir> repository)
           : base(repository)
        {

        }
    }
}
