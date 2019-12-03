using RLCore.RLAppService.Channel.Dtos;
using RLCore.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.Channel
{
    public interface IChannelAppService : IPagedResultAppService<ChannelOutput, int, GetInput>
    {
    }
}
