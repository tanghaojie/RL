using RLCore.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RLCore.RLAppService.RiverPatrol.Dtos
{
    public class StartInput
    {
        public int? ManagerId { get; set; }

        [Required]
        public int RiverId { get; set; }

        public XYCoordinate Point { get; set; }
    }
}
