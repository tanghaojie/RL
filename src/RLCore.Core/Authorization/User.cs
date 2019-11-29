using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using RLCore.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RLCore.Authorization
{
    public class User : Entity, IHasCreationTime//, IHasOrder
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }

        [Required]
        public string Realname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        [Required]
        public UserGender Gender { get; set; } = UserGender.Secret;
        public DateTime? Birthday { get; set; }
        public string Remark { get; set; }

        [Required]
        public UserState State { get; set; } = UserState.Active;

        public string LimitAgent { get; set; }
        public string LimitProtocol { get; set; }
        public string LimitIp { get; set; }

        public string LastIp { get; set; }
        public DateTime? LastLogin { get; set; }


        [Required]
        public DateTime CreationTime { get; set; } = DateTime.Now;

    }
}
