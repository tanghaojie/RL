using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RLCore.Configuration.Optional.Entities
{
    [Serializable]
    public class SingleTableOptionalTree : TreeEntity<SingleTableOptionalTree>, ITreeEntity<SingleTableOptionalTree>, IHasCreationTime
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
