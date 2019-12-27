using RLCore.Configuration;
using RLCore.Configuration.Optional.Manager;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.RLAppService.RiverPatrolEvent
{
    public class RiverPatrolEventAppService: IRiverPatrolEventAppService
    {
        private readonly IOptionTreeSharedTableConfigurationManager _IJTConfigurationManager;

        public const string TYPE = "QQ";

        public RiverPatrolEventAppService(
            IOptionTreeSharedTableConfigurationManager IJTConfigurationManager
            )
        {
            _IJTConfigurationManager = IJTConfigurationManager;
        }
    }
} 
