using Abp.Application.Services.Dto;
using AutoMapper;
using RLCore.Configuration;
using RLCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.Services.TreeConfigurationAppService
{
    public abstract class TreeConfigurationMapProfile<TEntityDto, TCreateInput, TUpdateByIdInput> : Profile
        where TEntityDto : IEntityDto<int>
        where TUpdateByIdInput : IEntityDto<int>
    {
        public TreeConfigurationMapProfile()
        {
            CreateMap<TreeConfiguration, TEntityDto>();
            CreateMap<TCreateInput, TreeConfiguration>();
            CreateMap<TUpdateByIdInput, TreeConfiguration>();
        }
    }
}
