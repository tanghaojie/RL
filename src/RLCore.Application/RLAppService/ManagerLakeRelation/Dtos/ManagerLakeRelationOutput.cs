using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RLCore.RLAppService.ManagerLakeRelation.Dtos
{
    public class ManagerLakeRelationOutput : EntityDto
    {
        [Required]
        public int ManagerId { get; set; }

        [Required]
        public int LakeId { get; set; }

        public DateTime CreationTime { get; set; }
    }
}
