using AutoMapper;
using RLCore.Services.Extension;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.RiverPatrolEvent.Dtos
{
    public class RiverPatrolEventMapProfile : Profile
    {
        public RiverPatrolEventMapProfile()
        {
            CreateMap<CreateInput, RL.RiverPatrolEvent>().ForMember(u => u.Location, options => options.MapFrom(src => src.Location.ToPoint()));
            CreateMap<RL.RiverPatrolEvent, RiverPatrolEventOutput>();
            CreateMap<UpdateByIdInput, RL.RiverPatrolEvent>().ForMember(u => u.Location, options => options.MapFrom(src => src.Location.ToPoint()));
        }
    }
}
