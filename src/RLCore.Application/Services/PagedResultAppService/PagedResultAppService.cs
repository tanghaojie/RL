using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace RLCore.Services
{
    public abstract class PagedResultAppService<TEntity, TEntityDto, TPrimaryKey, TGetInput> : ApplicationService,
        IPagedResultAppService<TEntityDto, TPrimaryKey, TGetInput>
        where TEntity : class, IEntity<TPrimaryKey>
        where TEntityDto : IEntityDto<TPrimaryKey>
        where TGetInput : IPagedResultRequest
    {
        protected readonly IRepository<TEntity, TPrimaryKey> Repository;
        protected PagedResultAppService(IRepository<TEntity, TPrimaryKey> repository)
        {
            Repository = repository;
        }

        public virtual PagedResultDto<TEntityDto> GetPaged(TGetInput input)
        {
            //Logger
            var res = Repository.GetAll();
            var total = res.Count();
            res = res.Skip(input.SkipCount).Take(input.MaxResultCount).OrderByDescending(e => e.Id);
            
            var entities = res.ToList();

            return new PagedResultDto<TEntityDto>(total, ObjectMapper.Map<List<TEntityDto>>(entities));
        }
    }
}
