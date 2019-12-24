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
    public class TreeConfigEntity : Entity, IHasCreationTime, ISoftDelete
    {
        [Required]
        public string ConfigName { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string Data { get; set; }

        public int? ParentId { get; set; }
        [ForeignKey("ParentId")]
        public virtual TreeConfigEntity Parent { get; set; }

        public virtual IList<TreeConfigEntity> Subs { get; set; }

        [Required]
        public DateTime CreationTime { get; set; } = DateTime.Now;

        [Required]
        public bool IsDeleted { get; set; } = false;
    }
}
