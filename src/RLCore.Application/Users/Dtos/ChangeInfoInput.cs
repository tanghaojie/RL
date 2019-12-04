using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.Users.Dtos
{
    public class ChangeInfoInput : EntityDto
    {
        public string Realname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public UserGender Gender { get; set; }
        public DateTime? Birthday { get; set; }
        public string Remark { get; set; }
    }
}
