using Abp.Domain.Entities;
using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RLCore.RL
{
    /// <summary>
    /// 河道河段
    /// </summary>
    public class River : Entity
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
        [NotMapped]
        public virtual bool BoundaryRiver {
            get { return BoundaryRiverBool > 0; }
            set {
                if (value) { BoundaryRiverBool = 1; }
                else { BoundaryRiverBool = 0; }
            }
        }
        public int? BoundaryRiverBool { get; set; }

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
        [NotMapped]
        public virtual bool NoLeader {
            get { return NoLeaderBool > 0; }
            set {
                if (value) { NoLeaderBool = 1; }
                else { NoLeaderBool = 0; }
            }
        }
        public int? NoLeaderBool { get; set; }

        /// <summary>
        /// 河段类型
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 界河左右岸标识
        /// </summary>
        public string Side { get; set; }

        [Column(TypeName = "geometry (MultiLineString)")]
        public MultiLineString Geom { get; set; }
    }
}
