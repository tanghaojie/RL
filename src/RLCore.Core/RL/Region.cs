using Abp.Domain.Entities;
using GeoAPI.Geometries;
using NetTopologySuite.Geometries;
using RLCore.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RLCore.RL
{
    public class Region : Entity, IGeom<MultiPolygon>
    {
        //var geo = new NetTopologySuite.Geometries.Point(20, 20);
        //    geo.SRID = 4326;

        /// <summary>
        /// 区域名称
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// 父级区域
        /// </summary>
        [Required]
        public string Parent { get; set; }

        /// <summary>
        /// 区域代码
        /// </summary>
        [Required]
        public string Pac { get; set; }

        /// <summary>
        /// 等级
        /// </summary>
        [Required]
        public string Level { get; set; }

        [Required, Column(TypeName = "geometry (multipolygon)")]
        public MultiPolygon Geom { get; set; }
    }
}
