using Abp.Application.Services.Dto;using System;using System.Collections.Generic;namespace RLCore.RLAppService.ManagerWetlandRelation.Dtos{    public class ManagerWetlandRelationOutput : EntityDto    {        public int ManagerId { get; set; }        public int WetlandId { get; set; }        public DateTime CreationTime { get; set; } = DateTime.Now;    }}