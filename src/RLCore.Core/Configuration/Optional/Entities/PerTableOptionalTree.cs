using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RLCore.Configuration.Optional.Entities
{
    public abstract class PerTableOptionalTree<TSelfEntity> : PerTableOptionalTree<TSelfEntity, int>
        where TSelfEntity : PerTableOptionalTree<TSelfEntity>
    { }

    public abstract class PerTableOptionalTree<TSelfEntity, TPrimaryKey> : TreeEntity<TSelfEntity, TPrimaryKey>, ITreeEntity<TSelfEntity, TPrimaryKey>, IHasCreationTime
        where TSelfEntity : PerTableOptionalTree<TSelfEntity, TPrimaryKey>
    {
        [Required]
        public virtual string Option { get; set; }

        public virtual string Description { get; set; }

        public virtual string Data { get; set; }

        [Required]
        public virtual DateTime CreationTime { get; set; } = DateTime.Now;
    }
}
