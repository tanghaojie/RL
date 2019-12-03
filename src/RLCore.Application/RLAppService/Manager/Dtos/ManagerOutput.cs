using Abp.Application.Services.Dto;
using RLCore.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.Manager.Dtos
{
    public class ManagerOutput : EntityDto
    {
        /// <summary>
        /// 河长名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 部门
        /// </summary>
        public string Department { get; set; }

        /// <summary>
        /// 职位
        /// </summary>
        public string Post { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Explain { get; set; }

        /// <summary>
        /// 级别
        /// </summary>
        public string AdRank { get; set; }

        /// <summary>
        /// 所在市
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 所在县
        /// </summary>
        public string County { get; set; }

        /// <summary>
        /// 所在乡镇
        /// </summary>
        public string Town { get; set; }

        /// <summary>
        /// 所在村
        /// </summary>
        public string Village { get; set; }

        /// <summary>
        /// 区域代码
        /// </summary>
        public string Pac { get; set; }

        /// <summary>
        /// 总河长
        /// </summary>
        public string Riverchief { get; set; }

        /// <summary>
        /// 是否担任河段
        /// </summary>
        public bool? HasNorv { get; set; }

        /// <summary>
        /// 所属流域
        /// </summary>
        public string Belongtobasin { get; set; }

        /// <summary>
        /// 管辖对象名称
        /// </summary>
        public string Manaobname { get; set; }
    }
}
