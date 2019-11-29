using Abp.Application.Services;

namespace RLCore
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class RLCoreAppServiceBase : ApplicationService
    {
        protected RLCoreAppServiceBase()
        {
            LocalizationSourceName = RLCoreConsts.LocalizationSourceName;
        }
    }
}