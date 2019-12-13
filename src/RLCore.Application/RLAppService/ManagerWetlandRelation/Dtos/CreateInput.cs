using System;using System.Collections.Generic;using System.ComponentModel.DataAnnotations;

namespace RLCore.RLAppService.ManagerWetlandRelation.Dtos{    public class CreateInput    {        [Required]        public int ManagerId { get; set; }        [Required]        public int WetlandId { get; set; }    }}