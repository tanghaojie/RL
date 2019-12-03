using GeoAPI.Geometries;

namespace RLCore.Entities
{
    public interface IGeom<TGeo> where TGeo : IGeometry
    {
        TGeo Geom { get; set; }
    }
}
