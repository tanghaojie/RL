using Abp.Authorization;
using Abp.Configuration.Startup;
using Abp.Dependency;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using Abp.Runtime;
using Abp.Runtime.Session;
using RLCore.RLAppService.Channel.Dtos;
using RLCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RLCore.RLAppService.Channel
{
    [AbpAuthorize]
    public class ChannelAppService : PagedResultAppService<RL.Channel, ChannelOutput, int, GetInput>, IChannelAppService
    {
        public ChannelAppService(IRepository<RL.Channel> repository)
           : base(repository)
        {
        }
    }


}
