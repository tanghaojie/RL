using RLCore.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RLCore.RLAppService.RiverPatrol.Dtos
{
    public class UploadPointsInput
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public XYTCoordinate[] Points { get; set; }
    }
}
