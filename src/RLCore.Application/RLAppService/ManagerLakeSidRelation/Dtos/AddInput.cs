using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RLCore.RLAppService.ManagerLakeSidRelation.Dtos
{
    public class AddInput
    {
        [Required]
        public int ManagerId { get; set; }

        [Required]
        public string LakeSid { get; set; }
    }
}
