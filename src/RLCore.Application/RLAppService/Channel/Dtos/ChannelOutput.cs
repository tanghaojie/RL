using Abp.Application.Services.Dto;
using RLCore.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.Channel.Dtos
{
    public class ChannelOutput : EntityDto, IWktGeomDto
    {
        /// <summary>
        /// 渠道代码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 渠道名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 渠道所属灌区名称
        /// </summary>
        public string Idname { get; set; }

        /// <summary>
        /// 渠道所属灌区类型
        /// </summary>
        public string Idtype { get; set; }

        /// <summary>
        /// 其上级渠道名称
        /// </summary>
        public string Prname { get; set; }

        /// <summary>
        /// 渠首位置
        /// </summary>
        public string Loc { get; set; }

        /// <summary>
        /// 渠道流经行政区划
        /// </summary>
        public string Flth { get; set; }

        /// <summary>
        /// 渠末位置
        /// </summary>
        public string Eloc { get; set; }

        /// <summary>
        /// 建成时间
        /// </summary>
        public string Bdtm { get; set; }

        /// <summary>
        /// 渠道管理单位
        /// </summary>
        public string Adag { get; set; }

        /// <summary>
        /// 渠道水源名称
        /// </summary>
        public string Prname1 { get; set; }

        /// <summary>
        /// 渠道类别
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 渠道现状水质类别
        /// </summary>
        public string Wqle { get; set; }

        /// <summary>
        /// 渠道主要功能
        /// </summary>
        public string Func { get; set; }

        /// <summary>
        /// 水质是否按渠道功能达标
        /// </summary>
        public string Wrus { get; set; }

        /// <summary>
        /// 入渠排污口数量
        /// </summary>
        public long? Count { get; set; }

        /// <summary>
        /// 设计流量
        /// </summary>
        public double? Flow { get; set; }

        /// <summary>
        /// 实际流量
        /// </summary>
        public double? Acfl { get; set; }

        /// <summary>
        /// 年输水量
        /// </summary>
        public double? Dpyn { get; set; }

        /// <summary>
        /// 年输水时间
        /// </summary>
        public long? Dpyt { get; set; }

        /// <summary>
        /// 渠道长度
        /// </summary>
        public double? Chle { get; set; }

        /// <summary>
        /// 渠道衬砌长度
        /// </summary>
        public double? Chleli { get; set; }

        /// <summary>
        /// 主要建筑物处数
        /// </summary>
        public long? Mbnu { get; set; }

        /// <summary>
        /// 设计控灌面积
        /// </summary>
        public double? Dcia { get; set; }

        /// <summary>
        /// 现有控灌面积
        /// </summary>
        public double? Ecia { get; set; }

        /// <summary>
        /// 受益人口（人饮）
        /// </summary>
        public double? Bepo { get; set; }

        /// <summary>
        /// 是否完成管理范围划定
        /// </summary>
        public string Wrcd { get; set; }

        /// <summary>
        /// 是否已确权颁证
        /// </summary>
        public string Wrco { get; set; }

        /// <summary>
        /// 所在流域
        /// </summary>
        public string Hnnm { get; set; }

        /// <summary>
        /// 主管部门级别
        /// </summary>
        public string Grad { get; set; }

        /// <summary>
        /// 行政区划
        /// </summary>
        public string Pac { get; set; }

        /// <summary>
        /// 渠道等级
        /// </summary>
        public string Level { get; set; }

        /// <summary>
        /// 唯一标识
        /// </summary>
        public string Sid { get; set; }

        /// <summary>
        /// 是否规模以上
        /// </summary>
        public string HasNew { get; set; }

        /// <summary>
        /// 是否设置有渠道长
        /// </summary>
        public string NoLeader { get; set; }

        /// <summary>
        /// 起点经度
        /// </summary>
        public double? Long { get; set; }

        /// <summary>
        /// 起点纬度
        /// </summary>
        public double? Lat { get; set; }

        /// <summary>
        /// 终点经度
        /// </summary>
        public double? ELong { get; set; }

        /// <summary>
        /// 终点纬度
        /// </summary>
        public double? ELat { get; set; }

        /// <summary>
        /// 使用年限
        /// </summary>
        public string StartDate { get; set; }

        /// <summary>
        /// 渠道分类
        /// </summary>
        public string Clas { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// 所在乡村
        /// </summary>
        public string Village { get; set; }

        public string Geom { get; set; }
    }
}
