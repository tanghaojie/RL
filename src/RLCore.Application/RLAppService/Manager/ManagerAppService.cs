using Abp.Authorization;
using Abp.Domain.Repositories;
using RLCore.RLAppService.Manager.Dtos;
using RLCore.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.Manager
{
    [AbpAuthorize]
    public class ManagerAppService : PagedResultAppService<RL.Manager, ManagerOutput, int, GetInput>, IManagerAppService
    {
        public ManagerAppService(IRepository<RL.Manager> repository)
           : base(repository)
        {

        }
    }
}
