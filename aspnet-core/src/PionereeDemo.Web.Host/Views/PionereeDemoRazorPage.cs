using Abp.AspNetCore.Mvc.Views;

namespace PionereeDemo.Web.Views;

public abstract class PionereeDemoRazorPage<TModel> : AbpRazorPage<TModel>
{
    protected PionereeDemoRazorPage()
    {
        LocalizationSourceName = PionereeDemoConsts.LocalizationSourceName;
    }
}

