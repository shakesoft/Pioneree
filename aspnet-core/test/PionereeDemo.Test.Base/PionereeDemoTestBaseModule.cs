using System;
using System.IO;
using Abp;
using Abp.AspNetZeroCore;
using Abp.Configuration.Startup;
using Abp.Dependency;
using Abp.Modules;
using Abp.Net.Mail;
using Abp.TestBase;
using Abp.Zero.Configuration;
using Castle.MicroKernel.Registration;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using PionereeDemo.Authorization.Users;
using PionereeDemo.Configuration;
using PionereeDemo.EntityFrameworkCore;
using PionereeDemo.MultiTenancy;
using PionereeDemo.Security.Recaptcha;
using PionereeDemo.Test.Base.DependencyInjection;
using PionereeDemo.Test.Base.UiCustomization;
using PionereeDemo.Test.Base.Url;
using PionereeDemo.Test.Base.Web;
using PionereeDemo.UiCustomization;
using PionereeDemo.Url;
using NSubstitute;

namespace PionereeDemo.Test.Base;

[DependsOn(
    typeof(PionereeDemoApplicationModule),
    typeof(PionereeDemoEntityFrameworkCoreModule),
    typeof(AbpTestBaseModule))]
public class PionereeDemoTestBaseModule : AbpModule
{
    public PionereeDemoTestBaseModule(PionereeDemoEntityFrameworkCoreModule abpZeroTemplateEntityFrameworkCoreModule)
    {
        abpZeroTemplateEntityFrameworkCoreModule.SkipDbContextRegistration = true;
    }

    public override void PreInitialize()
    {
        var configuration = GetConfiguration();

        Configuration.BackgroundJobs.IsJobExecutionEnabled = false;

        Configuration.UnitOfWork.Timeout = TimeSpan.FromMinutes(30);
        Configuration.UnitOfWork.IsTransactional = false;

        //Use database for language management
        Configuration.Modules.Zero().LanguageManagement.EnableDbLocalization();

        RegisterFakeService<AbpZeroDbMigrator>();
        RegisterFakeService<IHttpContextAccessor>();

        IocManager.Register<IAppUrlService, FakeAppUrlService>();
        IocManager.Register<IWebUrlService, FakeWebUrlService>();
        IocManager.Register<IRecaptchaValidator, FakeRecaptchaValidator>();

        Configuration.ReplaceService<IAppConfigurationAccessor, TestAppConfigurationAccessor>();
        Configuration.ReplaceService<IEmailSender, NullEmailSender>(DependencyLifeStyle.Transient);
        Configuration.ReplaceService<IUiThemeCustomizerFactory, NullUiThemeCustomizerFactory>();

        Configuration.Modules.AspNetZero().LicenseCode = configuration["AbpZeroLicenseCode"];

        //Uncomment below line to write change logs for the entities below:
        Configuration.EntityHistory.IsEnabled = true;
        Configuration.EntityHistory.Selectors.Add("PionereeDemoEntities", typeof(User), typeof(Tenant));
    }

    public override void Initialize()
    {
        ServiceCollectionRegistrar.Register(IocManager);
    }

    private void RegisterFakeService<TService>()
        where TService : class
    {
        IocManager.IocContainer.Register(
            Component.For<TService>()
                .UsingFactoryMethod(() => Substitute.For<TService>())
                .LifestyleSingleton()
        );
    }

    private static IConfigurationRoot GetConfiguration()
    {
        return AppConfigurations.Get(Directory.GetCurrentDirectory(), addUserSecrets: true);
    }
}
