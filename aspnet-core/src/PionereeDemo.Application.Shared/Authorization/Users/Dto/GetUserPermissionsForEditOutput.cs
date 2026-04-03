using System.Collections.Generic;
using PionereeDemo.Authorization.Permissions.Dto;

namespace PionereeDemo.Authorization.Users.Dto;

public class GetUserPermissionsForEditOutput
{
    public List<FlatPermissionDto> Permissions { get; set; }

    public List<string> GrantedPermissionNames { get; set; }
}

