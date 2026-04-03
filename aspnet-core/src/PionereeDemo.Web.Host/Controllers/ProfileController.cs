using Abp.AspNetCore.Mvc.Authorization;
using PionereeDemo.Authorization.Users.Profile;
using PionereeDemo.Storage;

namespace PionereeDemo.Web.Controllers;

[AbpMvcAuthorize]
public class ProfileController : ProfileControllerBase
{
    public ProfileController(
        ITempFileCacheManager tempFileCacheManager,
        IProfileAppService profileAppService) :
        base(tempFileCacheManager, profileAppService)
    {
    }
}

