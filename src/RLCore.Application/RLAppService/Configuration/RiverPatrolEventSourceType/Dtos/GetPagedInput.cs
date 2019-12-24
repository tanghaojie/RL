using Abp.Application.Services.Dto;
using RLCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.Configuration.RiverPatrolEventSourceType.Dtos
{
    public class GetPagedInput : IConfigPagedResultRequest
    {
        public int SkipCount { get; set; } = 0;
        public int MaxResultCount { get; set; } = 10;

        public bool TopOnly { get; set; } = true;
    }
}
