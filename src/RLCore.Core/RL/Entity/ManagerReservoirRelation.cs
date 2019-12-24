using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RLCore.RL
{
    public class ManagerReservoirRelation : Entity, IHasCreationTime
    {
        [Required]
        public int ManagerId { get; set; }
        [ForeignKey("ManagerId")]
        public virtual Manager Manager { get; set; }

        [Required]
        public int ReservoirId { get; set; }
        [ForeignKey("ReservoirId")]
        public virtual Reservoir Reservoir { get; set; }

        [Required]
        public DateTime CreationTime { get; set; } = DateTime.Now;
    }
}
