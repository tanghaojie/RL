using Abp.Application.Services.Dto;
using AutoMapper;
using RLCore.Configuration.Optional.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.Services
{
    public abstract class PerTableOptionalTreeConfigurationMapProfile<TEntity, TEntityDto, TCreateInput, TUpdateByIdInput>
        : PerTableOptionalTreeConfigurationMapProfile<TEntity, TEntityDto, TCreateInput, TUpdateByIdInput, int>
      where TEntity : class, ITreeEntity<TEntity>
      where TEntityDto : IEntityDto
      where TUpdateByIdInput : IEntityDto
    {
    
    }


    public abstract class PerTableOptionalTreeConfigurationMapProfile<TEntity, TEntityDto, TCreateInput, TUpdateByIdInput, TPrimaryKey> : Profile
        where TEntity : class, ITreeEntity<TEntity, TPrimaryKey>
        where TEntityDto : IEntityDto<TPrimaryKey>
        where TUpdateByIdInput : IEntityDto<TPrimaryKey>
    {
        public PerTableOptionalTreeConfigurationMapProfile()
        {
            CreateMap<TEntity, TEntityDto>();
            CreateMap<TCreateInput, TEntity>();
            CreateMap<TUpdateByIdInput, TEntity>();
        }
    }
}
