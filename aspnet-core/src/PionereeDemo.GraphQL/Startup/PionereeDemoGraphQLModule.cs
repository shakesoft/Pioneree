using Abp.Modules;
using Abp.Reflection.Extensions;

namespace PionereeDemo.Startup;

[DependsOn(typeof(PionereeDemoCoreModule))]
public class PionereeDemoGraphQLModule : AbpModule
{
    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(typeof(PionereeDemoGraphQLModule).GetAssembly());
    }
}

