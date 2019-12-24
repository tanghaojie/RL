using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RL
{
    public enum RiverPatrolEventType
    {
        /// <summary>
        /// 乱采
        /// </summary>
        IllegalCollection,
        /// <summary>
        /// 乱堆
        /// </summary>
        IllegalStacked,
        /// <summary>
        /// 乱建
        /// </summary>
        IllegalBuild,
        /// <summary>
        /// 其他
        /// </summary>
        Other = 0
    }
}
