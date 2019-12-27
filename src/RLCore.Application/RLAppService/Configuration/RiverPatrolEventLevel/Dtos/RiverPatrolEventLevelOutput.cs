using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.Configuration.RiverPatrolEventLevel.Dtos
{
    public class RiverPatrolEventLevelOutput : EntityDto
    {
        public string Option { get; set; }

        public string Description { get; set; }

        public string Data { get; set; }

        public DateTime CreationTime { get; set; }
    }
}
