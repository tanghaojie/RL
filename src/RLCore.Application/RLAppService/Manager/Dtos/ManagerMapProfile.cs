using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.Manager.Dtos
{
    public class ManagerMapProfile : Profile
    {
        public ManagerMapProfile()
        {
            CreateMap<RL.Manager, ManagerOutput>();
        }
    }
}
