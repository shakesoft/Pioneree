using Abp.Modules;
using Abp.Reflection.Extensions;

namespace PionereeDemo;

public class PionereeDemoClientModule : AbpModule
{
    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(typeof(PionereeDemoClientModule).GetAssembly());
    }
}

