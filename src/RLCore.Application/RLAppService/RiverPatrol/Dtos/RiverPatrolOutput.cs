using Abp.Application.Services.Dto;
using NetTopologySuite.Geometries;
using RLCore.RL;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.RiverPatrol.Dtos
{
    public class RiverPatrolOutput : EntityDto
    {
        public int UserId { get; set; }

        public int? ManagerId { get; set; }

        public int RiverId { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public PatrolState State { get; set; }

        public string StartPoint { get; set; }

        public string EndPoint { get; set; }

        public TrackCls Track { get; set; }

    }
    public class TrackCls
    {
        public string Track { get; set; }
        public IndexAndSecond[] IndexAndSeconds { get; set; }
    }
    public class IndexAndSecond
    {
        public int Index { get; set; }
        public int Second { get; set; }
    }
}
