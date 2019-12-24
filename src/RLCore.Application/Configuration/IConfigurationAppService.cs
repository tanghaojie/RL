using Abp.Application.Services;
using RLCore.Configuration.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RLCore.Configuration
{
    public interface IConfigurationAppService : IApplicationService
    {
        Task<RiverPatrolEventTypeOutput> AddRiverPatrolEventType(AddRiverPatrolEventTypeInput input);

        Task<IList<RiverPatrolEventTypeOutput>> GetAllRiverPatrolEventType();

        Task Delete(int id);

    }
}
