using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RLCore.RLAppService.ManagerLakeRelation.Dtos
{
    public class CreateInput
    {
        [Required]
        public int ManagerId { get; set; }

        [Required]
        public int LakeId { get; set; }
    }
}
