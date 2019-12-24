using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.Entities
{
    public interface IConfigPagedResultRequest : IPagedResultRequest
    {
        bool TopOnly { get; set; }
    }
}
