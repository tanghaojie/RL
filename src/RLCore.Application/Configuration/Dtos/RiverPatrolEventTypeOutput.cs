using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.Configuration.Dtos
{
    public class RiverPatrolEventTypeOutput
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Data { get; set; }

        public RiverPatrolEventTypeOutput Parent { get; set; }

        public IList<RiverPatrolEventTypeOutput> Subs { get; set; }

        public DateTime CreationTime { get; set; }
    }
}
