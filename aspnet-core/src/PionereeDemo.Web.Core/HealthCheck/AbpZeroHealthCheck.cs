using Microsoft.Extensions.DependencyInjection;
using PionereeDemo.HealthChecks;

namespace PionereeDemo.Web.HealthCheck;

public static class AbpZeroHealthCheck
{
    public static IHealthChecksBuilder AddAbpZeroHealthCheck(this IServiceCollection services)
    {
        var builder = services.AddHealthChecks();
        builder.AddCheck<PionereeDemoDbContextHealthCheck>("Database Connection");
        builder.AddCheck<PionereeDemoDbContextUsersHealthCheck>("Database Connection with user check");
        builder.AddCheck<CacheHealthCheck>("Cache");

        // add your custom health checks here
        // builder.AddCheck<MyCustomHealthCheck>("my health check");

        return builder;
    }
}

