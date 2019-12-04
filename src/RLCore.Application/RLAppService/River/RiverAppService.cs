using Abp.Authorization;
using Abp.Domain.Repositories;
using RLCore.RLAppService.River.Dtos;
using RLCore.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.River
{
    [AbpAuthorize]
    public class RiverAppService : PagedResultAppService<RL.River, RiverOutput, int, GetInput>, IRiverAppService
    {
        public RiverAppService(IRepository<RL.River> repository)
           : base(repository)
        {

        }
    }
}
