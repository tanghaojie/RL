using AutoMapper;
using RLCore.Configuration;
using RLCore.Services.TreeConfigurationAppService;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.Configuration.RiverPatrolEventSourceType.Dtos
{
    public class RiverPatrolEventSourceTypeMapProfile : TreeConfigurationMapProfile<RiverPatrolEventSourceTypeOutput, CreateInput, UpdateByIdInput>
    {
    }
}
