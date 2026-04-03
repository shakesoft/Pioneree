using Abp.AspNetCore.Mvc.ViewComponents;

namespace PionereeDemo.Web.Public.Views;

public abstract class PionereeDemoViewComponent : AbpViewComponent
{
    protected PionereeDemoViewComponent()
    {
        LocalizationSourceName = PionereeDemoConsts.LocalizationSourceName;
    }
}

