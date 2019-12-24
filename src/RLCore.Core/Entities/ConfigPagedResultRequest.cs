using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.Entities
{
    public class ConfigPagedResultRequest : PagedAndSortedResultRequestDto, IConfigPagedResultRequest
    {
        public ConfigPagedResultRequest()
        {
            TopOnly = true;
        }
        public bool TopOnly { get; set; }
    }
}
