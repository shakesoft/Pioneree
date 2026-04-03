using Abp.AspNetZeroCore;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.MicroKernel.Registration;
using Microsoft.Extensions.Configuration;
using PionereeDemo.Configuration;
using PionereeDemo.EntityFrameworkCore;
using PionereeDemo.Migrator.DependencyInjection;

namespace PionereeDemo.Migrator;

[DependsOn(typeof(PionereeDemoEntityFrameworkCoreModule))]
public class PionereeDemoMigratorModule : AbpModule
{
    private readonly IConfigurationRoot _appConfiguration;

    public PionereeDemoMigratorModule(PionereeDemoEntityFrameworkCoreModule abpZeroTemplateEntityFrameworkCoreModule)
    {
        abpZeroTemplateEntityFrameworkCoreModule.SkipDbSeed = true;

        _appConfiguration = AppConfigurations.Get(
            typeof(PionereeDemoMigratorModule).GetAssembly().GetDirectoryPathOrNull(),
            addUserSecrets: true
        );
    }

    public override void PreInitialize()
    {
        Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
            PionereeDemoConsts.ConnectionStringName
            );
        Configuration.Modules.AspNetZero().LicenseCode = _appConfiguration["AbpZeroLicenseCode"];

        Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        Configuration.ReplaceService(typeof(IEventBus), () =>
        {
            IocManager.IocContainer.Register(
                Component.For<IEventBus>().Instance(NullEventBus.Instance)
            );
        });
    }

    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(typeof(PionereeDemoMigratorModule).GetAssembly());
        ServiceCollectionRegistrar.Register(IocManager);
    }
}

