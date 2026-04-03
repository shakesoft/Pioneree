using Abp.Modules;
using Abp.Reflection.Extensions;

namespace PionereeDemo;

[DependsOn(typeof(PionereeDemoCoreSharedModule))]
public class PionereeDemoApplicationSharedModule : AbpModule
{
    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(typeof(PionereeDemoApplicationSharedModule).GetAssembly());
    }
}

