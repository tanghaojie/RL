using Abp.Domain.Entities;
using System.Collections.Generic;

namespace RLCore.Configuration.Optional.Entities
{
    public class TreeEntity<TSelfEntity> : TreeEntity<TSelfEntity, int>
        where TSelfEntity : class, ITreeEntity<TSelfEntity>
    { }
    public class TreeEntity<TSelfEntity, TPrimaryKey> : Entity<TPrimaryKey>, ITreeEntity<TSelfEntity, TPrimaryKey>
        where TSelfEntity : class, ITreeEntity<TSelfEntity, TPrimaryKey>
    {
        public virtual TSelfEntity Parent { get; set; }

        public virtual IList<TSelfEntity> Subs { get; set; }

        public int? ParentId { get; set; }
    }
}
