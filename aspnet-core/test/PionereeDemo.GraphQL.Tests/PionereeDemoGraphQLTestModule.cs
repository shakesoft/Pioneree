using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using PionereeDemo.Configure;
using PionereeDemo.Startup;
using PionereeDemo.Test.Base;

namespace PionereeDemo.GraphQL.Tests;

[DependsOn(
    typeof(PionereeDemoGraphQLModule),
    typeof(PionereeDemoTestBaseModule))]
public class PionereeDemoGraphQLTestModule : AbpModule
{
    public override void PreInitialize()
    {
        IServiceCollection services = new ServiceCollection();

        services.AddAndConfigureGraphQL();

        WindsorRegistrationHelper.CreateServiceProvider(IocManager.IocContainer, services);
    }

    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(typeof(PionereeDemoGraphQLTestModule).GetAssembly());
    }
}