using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.Region.Dtos
{
    public class RegionMapProfile : Profile
    {
        public RegionMapProfile()
        {
            CreateMap<RL.Region, RegionOutput>();
        }
    }
}
