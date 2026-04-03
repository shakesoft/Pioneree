using Abp.Application.Services.Dto;

namespace PionereeDemo.Maui.Models.Common;

public class TenantLoginInfoPersistanceModel : EntityDto
{
    public string TenancyName { get; set; }

    public string Name { get; set; }
}