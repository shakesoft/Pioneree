using Abp.Auditing;
using PionereeDemo.Configuration.Dto;

namespace PionereeDemo.Configuration.Tenants.Dto;

public class TenantEmailSettingsEditDto : EmailSettingsEditDto
{
    public bool UseHostDefaultEmailSettings { get; set; }
}

