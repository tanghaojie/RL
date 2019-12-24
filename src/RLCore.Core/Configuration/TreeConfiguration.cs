using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace RLCore.Configuration
{
    [Serializable]
    public class TreeConfiguration : Entity, IHasCreationTime
    {
        [Required]
        public string ConfigName { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string Data { get; set; }

        public int? ParentId { get; set; }
        [ForeignKey("ParentId")]
        public virtual TreeConfiguration Parent { get; set; }

        public virtual IList<TreeConfiguration> Subs { get; set; }

        [Required]
        public DateTime CreationTime { get; set; } = DateTime.Now;

    }
}
