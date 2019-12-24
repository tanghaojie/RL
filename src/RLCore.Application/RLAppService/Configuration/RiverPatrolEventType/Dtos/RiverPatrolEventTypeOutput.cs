using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.Configuration.RiverPatrolEventType.Dtos
{
    public class RiverPatrolEventTypeOutput : EntityDto
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Data { get; set; }

        public IList<RiverPatrolEventTypeOutput> Subs { get; set; }

        public DateTime CreationTime { get; set; }
    }
}
