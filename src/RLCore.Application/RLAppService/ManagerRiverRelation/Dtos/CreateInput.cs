using System;using System.Collections.Generic;using System.ComponentModel.DataAnnotations;

namespace RLCore.RLAppService.ManagerRiverRelation.Dtos{    public class CreateInput    {
        [Required]        public int ManagerId { get; set; }        [Required]        public int RiverId { get; set; }    }}