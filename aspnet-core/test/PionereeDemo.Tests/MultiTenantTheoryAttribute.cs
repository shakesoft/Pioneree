using Xunit;

namespace PionereeDemo.Tests;

public sealed class MultiTenantTheoryAttribute : TheoryAttribute
{
    private readonly bool _multiTenancyEnabled = PionereeDemoConsts.MultiTenancyEnabled;

    public MultiTenantTheoryAttribute()
    {
        if (!_multiTenancyEnabled)
        {
            Skip = "MultiTenancy is disabled.";
        }
    }
}