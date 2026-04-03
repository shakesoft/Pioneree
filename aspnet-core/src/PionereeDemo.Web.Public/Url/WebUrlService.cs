using Abp.Dependency;
using PionereeDemo.Configuration;
using PionereeDemo.Url;
using PionereeDemo.Web.Url;

namespace PionereeDemo.Web.Public.Url;

public class WebUrlService : WebUrlServiceBase, IWebUrlService, ITransientDependency
{
    public WebUrlService(
        IAppConfigurationAccessor appConfigurationAccessor) :
        base(appConfigurationAccessor)
    {
    }

    public override string WebSiteRootAddressFormatKey => "App:WebSiteRootAddress";

    public override string ServerRootAddressFormatKey => "App:AdminWebSiteRootAddress";
}

