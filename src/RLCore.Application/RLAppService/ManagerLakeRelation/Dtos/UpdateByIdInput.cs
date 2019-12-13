using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RLCore.RLAppService.ManagerLakeRelation.Dtos
{
    public class UpdateByIdInput : IEntityDto
    {
        [Required]
        public int Id { get; set; }
    }
}
