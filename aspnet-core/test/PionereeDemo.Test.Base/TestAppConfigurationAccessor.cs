using Abp.Dependency;
using Abp.Reflection.Extensions;
using Microsoft.Extensions.Configuration;
using PionereeDemo.Configuration;

namespace PionereeDemo.Test.Base;

public class TestAppConfigurationAccessor : IAppConfigurationAccessor, ISingletonDependency
{
    public IConfigurationRoot Configuration { get; }

    public TestAppConfigurationAccessor()
    {
        Configuration = AppConfigurations.Get(
            typeof(PionereeDemoTestBaseModule).GetAssembly().GetDirectoryPathOrNull()
        );
    }
}
