using RLCore;
using RLCore.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RLCore.RLAppService.RiverPatrolEvent.Dtos
{
    public class CreateInput
    {
        [Required]
        public int UserId { get; set; }


        [Required]
        public int RiverPatrolId { get; set; }

        [Required]
        public int RiverPatrolEventTypeId { get; set; }

        public DateTime? EventDate { get; set; }

        [Required]
        public DateTime FindDate { get; set; }

        public DateTime? PlanFinishDate { get; set; }


        public string EventDescription { get; set; }


        [Required]
        public int RiverPatrolEventLevelId { get; set; }



        [Required]
        public int RiverPatrolEventSourceTypeId { get; set; }


        [Required]
        public XYCoordinate Location { get; set; }

        public string LocationDesciption { get; set; }
    }
}
