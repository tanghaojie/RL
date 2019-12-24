using Abp.Domain.Repositories;
using RLCore.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.Repositories
{
    public interface IConfigRepository : IRepository<TreeConfiguration>
    {
    }
}
