using RLCore.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.RiverPatrolEvent
{
    public class RiverPatrolEventAppService: IRiverPatrolEventAppService
    {
        private readonly ITreeConfigurationManager _IJTConfigurationManager;

        public const string TYPE = "QQ";

        public RiverPatrolEventAppService(
            ITreeConfigurationManager IJTConfigurationManager
            )
        {
            _IJTConfigurationManager = IJTConfigurationManager;
        }
    }
}
