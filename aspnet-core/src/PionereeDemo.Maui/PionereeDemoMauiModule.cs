using Abp.Mapperly;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PionereeDemo.ApiClient;
using PionereeDemo.Maui.Core;

namespace PionereeDemo.Maui;

[DependsOn(typeof(PionereeDemoClientModule), typeof(AbpMapperlyModule))]
public class PionereeDemoMauiModule : AbpModule
{
    public override void PreInitialize()
    {
        Configuration.Localization.IsEnabled = false;
        Configuration.BackgroundJobs.IsJobExecutionEnabled = false;

        Configuration.ReplaceService<IApplicationContext, MauiApplicationContext>();
    }

    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(typeof(PionereeDemoMauiModule).GetAssembly());
    }
}