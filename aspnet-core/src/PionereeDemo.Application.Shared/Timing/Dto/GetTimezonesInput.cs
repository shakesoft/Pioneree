using Abp.Configuration;

namespace PionereeDemo.Timing.Dto;

public class GetTimezonesInput
{
    public SettingScopes DefaultTimezoneScope { get; set; }
}

