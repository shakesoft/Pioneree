using Abp.Authorization;
using PionereeDemo.Authorization.Roles;
using PionereeDemo.Authorization.Users;

namespace PionereeDemo.Authorization;

public class PermissionChecker : PermissionChecker<Role, User>
{
    public PermissionChecker(UserManager userManager)
        : base(userManager)
    {

    }
}

