using Abp.Domain.Entities;
using NetTopologySuite.Geometries;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RLCore.RL
{
    /// <summary>
    /// 湖泊湖片
    /// </summary>
    public class Lake : Entity
    {
        /// <summary>
        /// 湖片代码
        /// </summary>
        public string Hydc { get; set; }

        /// <summary>
        /// 湖片名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 湖片别名
        /// </summary>
        public string Alias { get; set; }

        /// <summary>
        /// 左下角经度
        /// </summary>
        public double? LowLeftLong { get; set; }

        /// <summary>
        /// 左下角纬度
        /// </summary>
        public double? LowLeftLat { get; set; }

        /// <summary>
        /// 右下角经度
        /// </summary>
        public double? UpRightLong { get; set; }

        /// <summary>
        /// 右下角纬度
        /// </summary>
        public double? UpRightLat { get; set; }

        /// <summary>
        /// 湖片标识符
        /// </summary>
        public string Sid { get; set; }

        /// <summary>
        /// 跨界类型
        /// </summary>
        public string CrOverType { get; set; }

        /// <summary>
        /// 湖泊所在位置
        /// </summary>
        public string Loc { get; set; }

        /// <summary>
        /// 湖泊容积
        /// </summary>
        public double? Vol { get; set; }

        /// <summary>
        /// 所在地代码
        /// </summary>
        public string Pac { get; set; }

        /// <summary>
        /// 管理面积
        /// </summary>
        public double? Area { get; set; }

        /// <summary>
        /// 湖片管理级别
        /// </summary>
        public string Level { get; set; }

        /// <summary>
        /// 咸淡水属性
        /// </summary>
        public string Wql { get; set; }

        /// <summary>
        /// 所属水系
        /// </summary>
        public string Basin { get; set; }

        /// <summary>
        /// 汇入河流
        /// </summary>
        public string River { get; set; }

        /// <summary>
        /// 平均水深
        /// </summary>
        public double? MeaAnnWatDept { get; set; }

        /// <summary>
        /// 最大水深
        /// </summary>
        public double? MaxDept { get; set; }

        /// <summary>
        /// 是否新增记录
        /// </summary>
        [NotMapped]
        public bool? HasNew {
            get {
                if (!HasNewBool.HasValue)
                {
                    return null;
                }
                return HasNewBool.Value > 0;
            }
            set {
                if (value.HasValue)
                {
                    if (value.Value)
                    {
                        HasNewBool = 1;
                    }
                    else
                    {
                        HasNewBool = 0;
                    }
                }
                else
                {
                    HasNewBool = null;
                }
            }
        }
        public int? HasNewBool { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// 是否分配河长
        /// </summary>
        [NotMapped]
        public bool? Noleader {
            get {
                if (!NoleaderBool.HasValue)
                {
                    return null;
                }
                return NoleaderBool.Value > 0;
            }
            set {
                if (value.HasValue)
                {
                    if (value.Value)
                    {
                        NoleaderBool = 1;
                    }
                    else
                    {
                        NoleaderBool = 0;
                    }
                }
                else
                {
                    NoleaderBool = null;
                }
            }
        }
        public int? NoleaderBool { get; set; }

        /// <summary>
        /// 所在村庄
        /// </summary>
        public string Village { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 记录生效时间
        /// </summary>
        public DateTime? EffDate { get; set; }

        /// <summary>
        /// 记录失效时间
        /// </summary>
        public DateTime? ExprDate { get; set; }

        [Column(TypeName = "geometry (multipolygon)")]
        public MultiPolygon Geom { get; set; }
    }
}
