using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.Channel.Dtos
{
    public class ChannelMapProfile : Profile
    {
        public ChannelMapProfile()
        {
            CreateMap<RL.Channel, ChannelOutput>();
        }
    }
}
