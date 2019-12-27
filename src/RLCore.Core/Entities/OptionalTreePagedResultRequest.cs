using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.Entities
{
    public class OptionalTreePagedResultRequest : PagedAndSortedResultRequestDto, IOptionalTreePagedResultRequest
    {
        public OptionalTreePagedResultRequest()
        {
            TopOnly = true;
        }
        public bool TopOnly { get; set; }
    }
}
