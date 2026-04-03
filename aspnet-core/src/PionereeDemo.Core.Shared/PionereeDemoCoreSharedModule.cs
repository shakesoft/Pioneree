using Abp.Modules;
using Abp.Reflection.Extensions;

namespace PionereeDemo;

public class PionereeDemoCoreSharedModule : AbpModule
{
    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(typeof(PionereeDemoCoreSharedModule).GetAssembly());
    }
}

