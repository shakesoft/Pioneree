using Abp.Domain.Services;

namespace PionereeDemo;

public abstract class PionereeDemoDomainServiceBase : DomainService
{
    /* Add your common members for all your domain services. */

    protected PionereeDemoDomainServiceBase()
    {
        LocalizationSourceName = PionereeDemoConsts.LocalizationSourceName;
    }
}

