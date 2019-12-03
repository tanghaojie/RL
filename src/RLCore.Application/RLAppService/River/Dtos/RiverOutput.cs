using Abp.Application.Services.Dto;
using RLCore.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.River.Dtos
{
    public class RiverOutput : EntityDto, IWktGeomDto
    {
        /// <summary>
        /// 水系名
        /// </summary>
        public string Srname { get; set; }

        /// <summary>
        /// 上级河流名
        /// </summary>
        public string Prname { get; set; }

        /// <summary>
        /// 河流名称
        /// </summary>
        public string Rname { get; set; }

        /// <summary>
        /// 河段名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 河段长度
        /// </summary>
        public double? Rlen { get; set; }

        /// <summary>
        /// 等级
        /// </summary>
        public string Grade { get; set; }

        /// <summary>
        /// 普查代码
        /// </summary>
        public string Censcode { get; set; }

        /// <summary>
        /// 干支级别
        /// </summary>
        public double? BranchLevel { get; set; }

        /// <summary>
        /// 岸别
        /// </summary>
        public string SideType { get; set; }

        /// <summary>
        /// 流域面积
        /// </summary>
        public double? Area { get; set; }

        /// <summary>
        /// 河口流量
        /// </summary>
        public double? Flow { get; set; }

        /// <summary>
        /// 跨区类型
        /// </summary>
        public string CrossType { get; set; }

        /// <summary>
        /// 河段标识符
        /// </summary>
        public string Sid { get; set; }

        /// <summary>
        /// 上游河段标识码
        /// </summary>
        public string SidUp { get; set; }

        /// <summary>
        /// 下游河段标识码
        /// </summary>
        public string SidDown { get; set; }

        /// <summary>
        /// 干支关系
        /// </summary>
        public string BranchRelation { get; set; }

        /// <summary>
        /// 河段别名
        /// </summary>
        public string Alias { get; set; }

        /// <summary>
        /// 区域代码
        /// </summary>
        public string Pac { get; set; }

        /// <summary>
        /// 是否界河
        /// </summary>
        public bool? BoundaryRiver { get; set; }

        /// <summary>
        /// 流经村
        /// </summary>
        public string ByVillage { get; set; }

        /// <summary>
        /// 河段等级
        /// </summary>
        public string Level { get; set; }

        /// <summary>
        /// 是否设河长
        /// </summary>
        public bool? NoLeader { get; set; }

        /// <summary>
        /// 河段类型
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 界河左右岸标识
        /// </summary>
        public string Side { get; set; }

        public string Geom { get; set; }
    }
}
