using Abp.Application.Services.Dto;
using AutoMapper;
using RLCore.Configuration;
using RLCore.Configuration.Optional.Entities;
using RLCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.Services
{
    public abstract class SingleTableOptionalTreeConfigurationMapProfile<TEntityDto, TCreateInput, TUpdateByIdInput> : Profile
        where TEntityDto : IEntityDto<int>
        where TUpdateByIdInput : IEntityDto<int>
    {
        public SingleTableOptionalTreeConfigurationMapProfile()
        {
            CreateMap<SingleTableOptionalTree, TEntityDto>();
            CreateMap<TCreateInput, SingleTableOptionalTree>();
            CreateMap<TUpdateByIdInput, SingleTableOptionalTree>();
        }
    }
}
