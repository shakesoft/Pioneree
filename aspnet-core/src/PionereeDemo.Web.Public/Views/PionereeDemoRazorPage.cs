using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace PionereeDemo.Web.Public.Views;

public abstract class PionereeDemoRazorPage<TModel> : AbpRazorPage<TModel>
{
    [RazorInject]
    public IAbpSession AbpSession { get; set; }

    protected PionereeDemoRazorPage()
    {
        LocalizationSourceName = PionereeDemoConsts.LocalizationSourceName;
    }
}

