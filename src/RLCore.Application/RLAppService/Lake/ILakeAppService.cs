using RLCore.RLAppService.Lake.Dtos;
using RLCore.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.Lake
{
    public interface ILakeAppService : IPagedResultAppService<LakeOutput, int, GetInput>
    {
    }
}
