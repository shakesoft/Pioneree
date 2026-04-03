using System.ComponentModel.DataAnnotations;

namespace PionereeDemo.Authorization.Accounts.Dto;

public class ImpersonateTenantInput
{
    public int? TenantId { get; set; }

    [Range(1, long.MaxValue)]
    public long UserId { get; set; }
}

