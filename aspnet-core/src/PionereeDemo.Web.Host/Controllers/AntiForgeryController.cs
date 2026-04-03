using Microsoft.AspNetCore.Antiforgery;

namespace PionereeDemo.Web.Controllers;

public class AntiForgeryController : PionereeDemoControllerBase
{
    private readonly IAntiforgery _antiforgery;

    public AntiForgeryController(IAntiforgery antiforgery)
    {
        _antiforgery = antiforgery;
    }

    public void GetToken()
    {
        _antiforgery.SetCookieTokenAndHeader(HttpContext);
    }
}

