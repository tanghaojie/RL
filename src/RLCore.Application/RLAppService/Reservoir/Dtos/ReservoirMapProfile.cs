using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.Reservoir.Dtos
{
    public class ReservoirMapProfile : Profile
    {
        public ReservoirMapProfile()
        {
            CreateMap<RL.Reservoir, ReservoirOutput>();
        }
    }
}
