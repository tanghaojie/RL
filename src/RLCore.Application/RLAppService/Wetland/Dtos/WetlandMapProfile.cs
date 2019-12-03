using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.Wetland.Dtos
{
    public class WetlandMapProfile : Profile
    {
        public WetlandMapProfile()
        {
            CreateMap<RL.Wetland, WetlandOutput>();
        }
    }
}
