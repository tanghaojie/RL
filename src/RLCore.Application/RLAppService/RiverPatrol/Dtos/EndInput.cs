using RLCore.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RLCore.RLAppService.RiverPatrol.Dtos
{
    public class EndInput
    {
        [Required]
        public int Id { get; set; }

        public XYCoordinate Point { get; set; }
    }
}
