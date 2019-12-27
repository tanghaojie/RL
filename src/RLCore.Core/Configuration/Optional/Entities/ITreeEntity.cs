using Abp.Domain.Entities;
using System.Collections.Generic;

namespace RLCore.Configuration.Optional.Entities
{
    public interface ITreeEntity<TSelfEntity> : ITreeEntity<TSelfEntity, int>, IEntity
        where TSelfEntity : class, ITreeEntity<TSelfEntity>
    { }

    public interface ITreeEntity<TSelfEntity, TPrimaryKey> : IEntity<TPrimaryKey>
        where TSelfEntity : class, ITreeEntity<TSelfEntity, TPrimaryKey>
    {
        TSelfEntity Parent { get; set; }

        IList<TSelfEntity> Subs { get; set; }

        int? ParentId { get; set; }
    }
}
