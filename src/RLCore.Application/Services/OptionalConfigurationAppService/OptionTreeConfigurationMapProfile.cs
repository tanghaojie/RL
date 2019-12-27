using Abp.Application.Services.Dto;
using AutoMapper;
using RLCore.Configuration.Optional.Entities;
using RLCore.Entities;

namespace RLCore.Services
{
    public abstract class OptionTreeConfigurationMapProfile<TEntity, TEntityDto, TCreateInput, TUpdateByIdInput>
        : OptionTreeConfigurationMapProfile<TEntity, TEntityDto, TCreateInput, TUpdateByIdInput, int>
      where TEntity : OptionTreeBase<TEntity>
      where TEntityDto : IEntityDto
      where TUpdateByIdInput : IEntityDto
    {
    
    }


    public abstract class OptionTreeConfigurationMapProfile<TEntity, TEntityDto, TCreateInput, TUpdateByIdInput, TPrimaryKey> : Profile
        where TEntity : OptionTreeBase<TEntity, TPrimaryKey>
        where TEntityDto : IEntityDto<TPrimaryKey>
        where TUpdateByIdInput : IEntityDto<TPrimaryKey>
    {
        public OptionTreeConfigurationMapProfile()
        {
            CreateMap<TEntity, TEntityDto>();
            CreateMap<TCreateInput, TEntity>();
            CreateMap<TUpdateByIdInput, TEntity>();
        }
    }
}
