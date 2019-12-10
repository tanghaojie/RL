using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.ManagerLakeRelation.Dtos
{
    public class UpdateByIdInput : IEntityDto
    {
        public int Id { get; set; }
    }
}
