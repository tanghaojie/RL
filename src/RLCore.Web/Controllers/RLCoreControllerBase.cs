using Abp.AspNetCore.Mvc.Controllers;

namespace RLCore.Web.Controllers
{
    public abstract class RLCoreControllerBase: AbpController
    {
        protected RLCoreControllerBase()
        {
            LocalizationSourceName = RLCoreConsts.LocalizationSourceName;
        }
    }
}