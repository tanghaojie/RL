using System;using System.Collections.Generic;using System.ComponentModel.DataAnnotations;

namespace RLCore.RLAppService.ManagerReservoirRelation.Dtos{    public class CreateInput    {
        [Required]        public int ManagerId { get; set; }        [Required]        public int ReservoirId { get; set; }    }}