using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RLCore.Configuration.Dtos
{
    public class AddRiverPatrolEventTypeInput
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string Data { get; set; }

        public int? ParentId { get; set; }
 
    }
}
