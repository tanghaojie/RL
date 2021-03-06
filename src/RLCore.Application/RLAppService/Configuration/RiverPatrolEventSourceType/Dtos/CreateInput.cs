﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RLCore.RLAppService.Configuration.RiverPatrolEventSourceType.Dtos
{
    public class CreateInput
    {
        [Required]
        public string Option { get; set; }

        public string Description { get; set; }

        public string Data { get; set; }
    }
}
