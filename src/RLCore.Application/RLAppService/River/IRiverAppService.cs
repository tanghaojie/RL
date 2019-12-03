using RLCore.RLAppService.River.Dtos;
using RLCore.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.River
{
    public interface IRiverAppService : IPagedResultAppService<RiverOutput, int, GetInput>
    {
    }
}
