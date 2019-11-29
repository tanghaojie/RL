using Abp.AspNetCore.Mvc.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace RLCore.Web.Host.Controllers
{
    public abstract  class RLCoreWebHostControllerBase : AbpController
    {
        protected RLCoreWebHostControllerBase()
        {
            LocalizationSourceName = RLCoreConsts.LocalizationSourceName;
        }
    }
}
