using Abp.Modules;
using Abp.Reflection.Extensions;
using PionereeDemo.Authorization;

namespace PionereeDemo;

/// <summary>
/// Application layer module of the application.
/// </summary>
[DependsOn(
    typeof(PionereeDemoApplicationSharedModule),
    typeof(PionereeDemoCoreModule)
    )]
public class PionereeDemoApplicationModule : AbpModule
{
    public override void PreInitialize()
    {
        //Adding authorization providers
        Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();
    }

    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(typeof(PionereeDemoApplicationModule).GetAssembly());
    }
}
