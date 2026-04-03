using Microsoft.Extensions.Configuration;

namespace PionereeDemo.Configuration;

public interface IAppConfigurationAccessor
{
    IConfigurationRoot Configuration { get; }
}

