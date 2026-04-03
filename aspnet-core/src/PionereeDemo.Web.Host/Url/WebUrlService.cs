using Abp.Dependency;
using PionereeDemo.Configuration;
using PionereeDemo.Url;

namespace PionereeDemo.Web.Url;

public class WebUrlService : WebUrlServiceBase, IWebUrlService, ITransientDependency
{
    public WebUrlService(
        IAppConfigurationAccessor configurationAccessor) :
        base(configurationAccessor)
    {
    }

    public override string WebSiteRootAddressFormatKey => "App:ClientRootAddress";

    public override string ServerRootAddressFormatKey => "App:ServerRootAddress";
}

