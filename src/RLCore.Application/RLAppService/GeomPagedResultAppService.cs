using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using GeoAPI.Geometries;
using RLCore.Entities;
using RLCore.Services;
using System.Linq;

namespace RLCore.RLAppService
{
    //public abstract class GeomPagedResultAppService<TEntity, TEntityDto, TPrimaryKey, TGetInput, TGeo>
    //    : PagedResultAppService<TEntity, TEntityDto, TPrimaryKey, TGetInput>, IGeomPagedResultAppService<TEntityDto, TPrimaryKey, TGetInput, TGeo>
    //    where TEntity : class, IEntity<TPrimaryKey>, IGeom<TGeo>
    //    where TEntityDto : IEntityDto<TPrimaryKey>, IWktGeomDto
    //    where TGetInput : IPagedResultRequest
    //    where TGeo : IGeometry
    //{
    //    public GeomPagedResultAppService(IRepository<TEntity, TPrimaryKey> repository) : base(repository) { }

    //    public override PagedResultDto<TEntityDto> Get(TGetInput input)
    //    {
    //        var res = Repository.GetAll();
    //        var total = res.Count();
    //        res = res.Skip(input.SkipCount).Take(input.MaxResultCount);

    //        var entities = res.ToList();
    //        var dtos = entities.Select(e =>
    //        {
    //            var result = ObjectMapper.Map<TEntityDto>(e);
    //            result.Geom = e.Geom.AsText();
    //            return result;
    //        }).ToList();

    //        return new PagedResultDto<TEntityDto>(total, dtos);
    //    }
    //}
}
