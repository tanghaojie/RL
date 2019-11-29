using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RLCore.Web.Host.Models
{
    public class AuthenticateModel
    {
        [Required]
        [StringLength(256)]
        public string UserNameOrEmailAddress { get; set; }

        [Required]
        [StringLength(256)]
        public string Password { get; set; }

        public bool RememberClient { get; set; }
    }
}
