﻿using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.Manager.Dtos
{
    public class GetInput : IPagedResultRequest
    {
        public int SkipCount { get; set; }
        public int MaxResultCount { get; set; }
    }
}
