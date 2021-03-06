﻿using AutoMapper;
using RLCore.Configuration;
using RLCore.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.Configuration.RiverPatrolEventType.Dtos
{
    public class RiverPatrolEventTypeMapProfile : OptionTreeConfigurationMapProfile<RL.RiverPatrolEventType, RiverPatrolEventTypeOutput, CreateInput, UpdateByIdInput>
    {
    }
}
