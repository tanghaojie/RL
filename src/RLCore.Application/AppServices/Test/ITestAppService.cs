using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.AppServices.Test
{
    public interface ITestAppService : IApplicationService
    {
        string Get(int i);

        (string, string) X(string path);
    }
}
