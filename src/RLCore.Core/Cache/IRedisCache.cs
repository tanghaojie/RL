using Abp.Dependency;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.Cache
{
    public interface IRedisCache : ISingletonDependency, IDisposable
    {

    }
}
