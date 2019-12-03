using Abp.Application.Services.Dto;
using RLCore.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.Lake.Dtos
{
    public class LakeOutput : EntityDto, IWktGeomDto
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
        public bool? HasNew { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// 是否分配河长
        /// </summary>
        public bool? Noleader { get; set; }

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

        public string Geom { get; set; }
    }
}
