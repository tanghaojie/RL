using Abp.Domain.Entities;
using NetTopologySuite.Geometries;
using RLCore.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RLCore.RL
{
    public class RiverPatrol : Entity
    {
        [Required]
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        public int? ManagerId { get; set; }
        [ForeignKey("ManagerId")]
        public virtual Manager Manager { get; set; }

        [Required]
        public int RiverId { get; set; }
        [ForeignKey("RiverId")]
        public virtual River River { get; set; }

        [Required]
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        [Required]
        public PatrolState State { get; set; } = PatrolState.Patrolling;


        [Column(TypeName = "geometry (point)")]
        public Point StartPoint { get; set; }

        [Column(TypeName = "geometry (point)")]
        public Point EndPoint { get; set; }

        [Column(TypeName = "geometry (LineString)")]
        public LineString Track { get; set; }

        /// <summary>
        /// 0 2 4 6 8 ... index;  1 3 5 7 9... Interval 
        /// </summary>
        public int[] TrackPointIndexAndSecondWithoutASecond { get; set; }
    }
}
