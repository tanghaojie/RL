using Abp.Application.Services.Dto;
using NetTopologySuite.Geometries;
using RLCore.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.Region.Dtos
{
    public class RegionOutput : EntityDto, IWktGeomDto
    {
        public string Name { get; set; }

        /// <summary>
        /// 父级区域
        /// </summary>
        public string Parent { get; set; }

        /// <summary>
        /// 区域代码
        /// </summary>
        public string Pac { get; set; }

        /// <summary>
        /// 等级
        /// </summary>
        public string Level { get; set; }

        public string Geom { get; set; }
    }
}
