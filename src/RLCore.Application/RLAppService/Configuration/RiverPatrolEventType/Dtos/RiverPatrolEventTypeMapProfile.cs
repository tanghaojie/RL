using AutoMapper;
using RLCore.Configuration;
using RLCore.Services.TreeConfigurationAppService;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.Configuration.RiverPatrolEventType.Dtos
{
    public class RiverPatrolEventTypeMapProfile : TreeConfigurationMapProfile<RiverPatrolEventTypeOutput, CreateInput, UpdateByIdInput>
    {
    }
}
