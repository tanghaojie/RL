using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RLCore.RL
{
    public class ManagerReservoirSidRelation : Entity, IHasCreationTime
    {
        [Required]
        public int ManagerId { get; set; }
        [ForeignKey("ManagerId")]
        public virtual Manager Manager { get; set; }

        [Required]
        public string ReservoirSid { get; set; }

        [Required]
        public DateTime CreationTime { get; set; } = DateTime.Now;
    }
}
