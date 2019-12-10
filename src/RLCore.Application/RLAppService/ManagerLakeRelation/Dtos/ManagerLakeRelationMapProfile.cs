using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.ManagerLakeRelation.Dtos
{
    public class ManagerLakeRelationMapProfile : Profile
    {
        public ManagerLakeRelationMapProfile()
        {
            CreateMap<CreateInput, RL.ManagerLakeRelation>();
            CreateMap<RL.ManagerLakeRelation, ManagerLakeRelationOutput>();
            CreateMap<UpdateByIdInput, RL.ManagerLakeRelation>();
        }
    }
}
