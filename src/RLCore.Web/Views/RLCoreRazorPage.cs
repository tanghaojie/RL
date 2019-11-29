using Abp.AspNetCore.Mvc.Views;

namespace RLCore.Web.Views
{
    public abstract class RLCoreRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected RLCoreRazorPage()
        {
            LocalizationSourceName = RLCoreConsts.LocalizationSourceName;
        }
    }
}
