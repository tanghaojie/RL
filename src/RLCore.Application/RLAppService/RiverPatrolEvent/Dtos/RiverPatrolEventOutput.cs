using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RLCore.RLAppService.RiverPatrolEvent.Dtos
{
    public class RiverPatrolEventOutput : EntityDto
    {
        public int UserId { get; set; }


        public int RiverPatrolId { get; set; }

        public int RiverPatrolEventTypeId { get; set; }

        public DateTime? EventDate { get; set; }

        public DateTime FindDate { get; set; }

        public DateTime? PlanFinishDate { get; set; }


        public string EventDescription { get; set; }


        public int RiverPatrolEventLevelId { get; set; }



        public int RiverPatrolEventSourceTypeId { get; set; }


        public string Location { get; set; }

        public string LocationDesciption { get; set; }
    }
}
