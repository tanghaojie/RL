using Abp.Domain.Repositories;
using RLCore.Configuration;
using RLCore.Configuration.Optional.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.Repositories
{
    public interface IConfigRepository : IRepository<OptionTreeSharedTable>
    {
    }
}
