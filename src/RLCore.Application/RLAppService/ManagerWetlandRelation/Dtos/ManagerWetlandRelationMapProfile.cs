using AutoMapper;using System;using System.Collections.Generic;namespace RLCore.RLAppService.ManagerWetlandRelation.Dtos{    public class ManagerWetlandRelationMapProfile : Profile    {        public ManagerWetlandRelationMapProfile()        {            CreateMap<CreateInput, RL.ManagerWetlandRelation>();            CreateMap<RL.ManagerWetlandRelation, ManagerWetlandRelationOutput>();            CreateMap<UpdateByIdInput, RL.ManagerWetlandRelation>();        }    }}