using Abp.Domain.Entities;
using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RLCore.RL
{
    /// <summary>
    /// 湿地
    /// </summary>
    public class Wetland : Entity
    {
        /// <summary>
        /// 省（市、区）
        /// </summary>
        public string Province { get; set; }

        /// <summary>
        /// 市（州）
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 县（区、市）
        /// </summary>
        public string County { get; set; }

        /// <summary>
        /// 湿地斑块名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 是否重点调查湿地
        /// </summary>
        public string Wrkr { get; set; }

        /// <summary>
        /// 调查类型
        /// </summary>
        public string Retype { get; set; }

        /// <summary>
        /// 重点调查湿地名称
        /// </summary>
        public string Krname { get; set; }

        /// <summary>
        /// 所属湿地区名称
        /// </summary>
        public string Waname { get; set; }

        /// <summary>
        /// 湿地区编码
        /// </summary>
        public string Waid { get; set; }

        /// <summary>
        /// 湿地类
        /// </summary>
        public string Clas { get; set; }

        /// <summary>
        /// 湿地型
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 面积
        /// </summary>
        public double? Area { get; set; }

        /// <summary>
        /// 平均海拔
        /// </summary>
        public double? Elev { get; set; }

        /// <summary>
        /// 所属三级流域
        /// </summary>
        public string Bscd { get; set; }

        /// <summary>
        /// 河流级别
        /// </summary>
        public string Rvlv { get; set; }

        /// <summary>
        /// 水源补给
        /// </summary>
        public string Wasu { get; set; }

        /// <summary>
        /// 植被面积
        /// </summary>
        public double? Vgar { get; set; }

        /// <summary>
        /// 土地所有权
        /// </summary>
        public string Owag { get; set; }

        /// <summary>
        /// 湿地斑块区划因子
        /// </summary>
        public string Fact { get; set; }

        /// <summary>
        /// 保护管理状况
        /// </summary>
        public string Pmst { get; set; }

        /// <summary>
        /// 调查人
        /// </summary>
        public string Inv { get; set; }

        /// <summary>
        /// 调查时间
        /// </summary>
        public string Inti { get; set; }

        /// <summary>
        /// 调查单位
        /// </summary>
        public string Inde { get; set; }

        /// <summary>
        /// 是否第一次调查
        /// </summary>
        public string Wrfi { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Note { get; set; }

        public string Pac { get; set; }

        public string Level { get; set; }

        public string Sid { get; set; }

        public string HasNew { get; set; }

        [NotMapped]
        public bool? NoLeader {
            get {
                if (!NoLeaderBool.HasValue)
                {
                    return null;
                }
                return NoLeaderBool.Value > 0;
            }
            set {
                if (value.HasValue)
                {
                    if (value.Value)
                    {
                        NoLeaderBool = 1;
                    }
                    else
                    {
                        NoLeaderBool = 0;
                    }
                }
                else
                {
                    NoLeaderBool = null;
                }
            }
        }
        public int? NoLeaderBool { get; set; }

        [Column(TypeName = "geometry (multipolygon)")]
        public MultiPolygon Geom { get; set; }
    }
}
