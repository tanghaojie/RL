using Abp.Domain.Entities.Auditing;
using RLCore.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RLCore.Configuration.Optional.Entities
{
    public abstract class OptionTreeBase<TSelfEntity> : OptionTreeBase<TSelfEntity, int>
        where TSelfEntity : OptionTreeBase<TSelfEntity>
    { }

    public abstract class OptionTreeBase<TSelfEntity, TPrimaryKey> : TreeEntity<TSelfEntity, TPrimaryKey>, ITreeEntity<TSelfEntity, TPrimaryKey>, IHasCreationTime
        where TSelfEntity : OptionTreeBase<TSelfEntity, TPrimaryKey>
    {
        [Required]
        public virtual string Option { get; set; }

        public virtual string Description { get; set; }

        public virtual string Data { get; set; }

        [Required]
        public virtual DateTime CreationTime { get; set; } = DateTime.Now;
    }
}
