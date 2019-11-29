using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RLCore.Users.Dtos
{
    public class CreateInput
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
    }
}
