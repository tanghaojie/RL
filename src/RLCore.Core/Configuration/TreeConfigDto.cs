using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RLCore.Configuration
{
    public class TreeConfigDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string Data { get; set; }

        public IList<TreeConfigDto> Subs { get; set; }

        [Required]
        public DateTime CreationTime { get; set; }
    }
}
