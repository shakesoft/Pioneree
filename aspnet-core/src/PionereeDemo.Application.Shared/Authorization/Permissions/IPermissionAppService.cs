using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PionereeDemo.Authorization.Permissions.Dto;

namespace PionereeDemo.Authorization.Permissions;

public interface IPermissionAppService : IApplicationService
{
    ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
}

