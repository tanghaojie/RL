using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.Configuration.Dtos
{
    public class ConfigurationMapProfile : Profile
    {
        public ConfigurationMapProfile()
        {
            CreateMap<TreeConfigDto, RiverPatrolEventTypeOutput>();
        }
    }
}
