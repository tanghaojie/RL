using Abp.Domain.Entities;
using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RLCore.RL
{
    /// <summary>
    /// 水库库片
    /// </summary>
    public class Reservoir : Entity
    {
        /// <summary>
        /// 水库代码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 水库名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 所在市（州）
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 所在县(市区）
        /// </summary>
        public string County { get; set; }

        /// <summary>
        /// 主坝所在乡镇
        /// </summary>
        public string Town { get; set; }

        /// <summary>
        /// 主坝所在村
        /// </summary>
        public string Village { get; set; }

        /// <summary>
        /// 注册登记号
        /// </summary>
        public string ReLicCode { get; set; }

        /// <summary>
        /// 总库容
        /// </summary>
        public double? Vol { get; set; }

        /// <summary>
        /// 水库规模
        /// </summary>
        public string Tegr { get; set; }

        /// <summary>
        /// 工程等别
        /// </summary>
        public string EngGrad { get; set; }

        /// <summary>
        /// 所在流域名称
        /// </summary>
        public string Hnnm { get; set; }

        /// <summary>
        /// 所在河流
        /// </summary>
        public string Rvnm { get; set; }

        /// <summary>
        /// 水库类型
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 主坝坐标经度
        /// </summary>
        public double? Long { get; set; }

        /// <summary>
        /// 主坝坐标纬度
        /// </summary>
        public double? Lat { get; set; }

        /// <summary>
        /// 主坝材料类型
        /// </summary>
        public string Matrl { get; set; }

        /// <summary>
        /// 主坝结构类型
        /// </summary>
        public string KdStrType { get; set; }

        /// <summary>
        /// 主坝最大坝高
        /// </summary>
        public double? Height { get; set; }

        /// <summary>
        /// 主坝坝长
        /// </summary>
        public double? KdLength { get; set; }

        /// <summary>
        /// 坝址控制流域面积
        /// </summary>
        public double? WatShedArea { get; set; }

        /// <summary>
        /// 坝址多年平均径流量
        /// </summary>
        public double? Flow { get; set; }

        /// <summary>
        /// 开工时间
        /// </summary>
        public string StartDate { get; set; }

        /// <summary>
        /// 建成时间
        /// </summary>
        public string Bdtm { get; set; }

        /// <summary>
        /// 水库调节性能
        /// </summary>
        public string Repe { get; set; }

        /// <summary>
        /// 正常溢洪道型式
        /// </summary>
        public string NsType { get; set; }

        /// <summary>
        /// 正常溢洪道堰型
        /// </summary>
        public string NsWeirType { get; set; }

        /// <summary>
        /// 正常溢洪道堰顶宽
        /// </summary>
        public double? NsWeirHeght { get; set; }

        /// <summary>
        /// 正常溢洪道是否有闸控制
        /// </summary>
        public string NsWrSlco { get; set; }

        /// <summary>
        /// 正常溢洪道最大泄洪流量
        /// </summary>
        public double? NsMaxRfw { get; set; }

        /// <summary>
        /// 是否有非常溢洪道
        /// </summary>
        public string WrAbns { get; set; }

        /// <summary>
        /// 非常溢洪道型式
        /// </summary>
        public string AbnsType { get; set; }

        /// <summary>
        /// 非常溢洪道启用标准
        /// </summary>
        public string AbnsStand { get; set; }

        /// <summary>
        /// 取水口数量
        /// </summary>
        public long? WainNum { get; set; }

        /// <summary>
        /// 取水口型式
        /// </summary>
        public string WainType { get; set; }

        /// <summary>
        /// 最大放水流量
        /// </summary>
        public double? MaxDifl { get; set; }

        /// <summary>
        /// 放空洞（底孔）型式
        /// </summary>
        public string EmtuType { get; set; }

        /// <summary>
        /// 最大泄洪流量
        /// </summary>
        public double? MaxRfw { get; set; }

        /// <summary>
        /// 设计洪水标准［重现期］
        /// </summary>
        public long? DeStand { get; set; }

        /// <summary>
        /// 校核洪水标准［重现期］
        /// </summary>
        public long? ChStand { get; set; }

        /// <summary>
        /// 高程系统
        /// </summary>
        public string Elsy { get; set; }

        /// <summary>
        /// 坝顶高程
        /// </summary>
        public double? DacrElev { get; set; }

        /// <summary>
        /// 校核洪水位
        /// </summary>
        public double? ChLev { get; set; }

        /// <summary>
        /// 设计洪水位
        /// </summary>
        public double? DeLev { get; set; }

        /// <summary>
        /// 防洪高水位
        /// </summary>
        public double? FlcoLev { get; set; }

        /// <summary>
        /// 正常蓄水位
        /// </summary>
        public double? WatLev { get; set; }

        /// <summary>
        /// 正常蓄水位相应库容
        /// </summary>
        public double? NormPoolStagCap { get; set; }

        /// <summary>
        /// 防洪限制水位
        /// </summary>
        public double? FlLowLimLev { get; set; }

        /// <summary>
        /// 防洪限制水位库容
        /// </summary>
        public double? FlLowLimLevCap { get; set; }

        /// <summary>
        /// 死水位
        /// </summary>
        public double? Elev { get; set; }

        /// <summary>
        /// 调洪库容
        /// </summary>
        public double? StorFlCap { get; set; }

        /// <summary>
        /// 防洪库容
        /// </summary>
        public double? FlcoCap { get; set; }

        /// <summary>
        /// 兴利库容
        /// </summary>
        public double? BenResCap { get; set; }

        /// <summary>
        /// 死库容
        /// </summary>
        public double? DeadCap { get; set; }

        /// <summary>
        /// 正常蓄水位相应水面面积
        /// </summary>
        public double? Area { get; set; }

        /// <summary>
        /// 水库主要功能
        /// </summary>
        public string Func { get; set; }

        /// <summary>
        /// 重要保护对象
        /// </summary>
        public string Mpob { get; set; }

        /// <summary>
        /// 供水对象
        /// </summary>
        public string Wsob { get; set; }

        /// <summary>
        /// 设计灌溉面积
        /// </summary>
        public double? DeIrar { get; set; }

        /// <summary>
        /// 灌溉对象
        /// </summary>
        public string Iaob { get; set; }

        /// <summary>
        /// 工程建设情况
        /// </summary>
        public string EngStat { get; set; }

        /// <summary>
        /// 归口主管部门
        /// </summary>
        public string AdmDep { get; set; }

        /// <summary>
        /// 主管部门名称
        /// </summary>
        public string AdmDepName { get; set; }

        /// <summary>
        /// 主管部门级别
        /// </summary>
        public string Grad { get; set; }

        /// <summary>
        /// 管理单位名称
        /// </summary>
        public string Adag { get; set; }

        /// <summary>
        /// 是否完成管理范围划定
        /// </summary>
        public string Wrcd { get; set; }

        /// <summary>
        /// 是否完成保护范围划定
        /// </summary>
        public string Wrpd { get; set; }

        /// <summary>
        /// 是否完成确权
        /// </summary>
        public string Wrco { get; set; }

        /// <summary>
        /// 是否饮水水源水库
        /// </summary>
        public string Wrws { get; set; }

        /// <summary>
        /// 是否备用饮水水源水库
        /// </summary>
        public string WrwsSp { get; set; }

        /// <summary>
        /// 是否划定饮用水水源保护区
        /// </summary>
        public string WrcdDp { get; set; }

        /// <summary>
        /// 入库排污口数量
        /// </summary>
        public long? Count { get; set; }

        /// <summary>
        /// 目前水库水质类别
        /// </summary>
        public string Wqle { get; set; }

        /// <summary>
        /// 目前水质是否按水库功能达标
        /// </summary>
        public string Wrrs { get; set; }

        /// <summary>
        /// 水质监测时间
        /// </summary>
        public string MoTime { get; set; }

        /// <summary>
        /// 水质监测单位
        /// </summary>
        public string Mnag { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// 不知道啥意思
        /// </summary>
        public string Ssk { get; set; }

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
