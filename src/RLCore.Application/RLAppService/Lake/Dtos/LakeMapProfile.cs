using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.Lake.Dtos
{
    public class LakeMapProfile : Profile
    {
        public LakeMapProfile()
        {
            CreateMap<RL.Lake, LakeOutput>();
        }
    }
}
