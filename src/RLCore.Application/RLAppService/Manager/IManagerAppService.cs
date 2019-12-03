using RLCore.RLAppService.Manager.Dtos;
using RLCore.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.Manager
{
    public interface IManagerAppService : IPagedResultAppService<ManagerOutput, int, GetInput>
    {
    }
}
