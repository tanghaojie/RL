using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using NetTopologySuite.Geometries;
using RLCore.Configuration;
using RLCore.Configuration.Optional.Entities;
using RLCore.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RLCore.RL
{
    public class RiverPatrolEvent : Entity, IHasCreationTime
    {
        [Required]
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        [Required]
        public int RiverPatrolEventSourceTypeId { get; set; }
        [ForeignKey("RiverPatrolEventSourceTypeId")]
        public virtual OptionTreeSharedTable RiverPatrolEventSourceType { get; set; }

        [Required]
        public int RiverPatrolId { get; set; }
        [ForeignKey("RiverPatrolId")]
        public virtual RiverPatrol RiverPatrol { get; set; }

        [Required]
        public int RiverPatrolEventTypeId { get; set; }
        [ForeignKey("RiverPatrolEventTypeId")]
        public virtual OptionTreeSharedTable RiverPatrolEventType { get; set; }

        public DateTime? EventDate { get; set; }

        [Required]
        public DateTime FindDate { get; set; }

        [Required]
        public DateTime CreationTime { get; set; } = DateTime.Now;

        public string EventDescription { get; set; }



        [Column(TypeName = "geometry (point)")]
        public Point Location { get; set; }

        public string LocationDesciption { get; set; }



    }
}
