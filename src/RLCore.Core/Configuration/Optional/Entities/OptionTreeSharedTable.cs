using Abp.Domain.Entities.Auditing;
using RLCore.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RLCore.Configuration.Optional.Entities
{
    [Serializable]
    public class OptionTreeSharedTable : TreeEntity<OptionTreeSharedTable>, ITreeEntity<OptionTreeSharedTable>, IHasCreationTime
    {
        [Required]
        public string OptionType { get; set; }

        [Required]
        public string Option { get; set; }

        public string Description { get; set; }

        public string Data { get; set; }

        [Required]
        public DateTime CreationTime { get; set; } = DateTime.Now;
    }
}
