using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.River.Dtos
{
    public class RiverMapProfile : Profile
    {
        public RiverMapProfile()
        {
            CreateMap<RL.River, RiverOutput>();
        }
    }
}
