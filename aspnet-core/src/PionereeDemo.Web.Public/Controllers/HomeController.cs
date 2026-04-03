using Microsoft.AspNetCore.Mvc;
using PionereeDemo.Web.Controllers;

namespace PionereeDemo.Web.Public.Controllers;

public class HomeController : PionereeDemoControllerBase
{
    public ActionResult Index()
    {
        return View();
    }
}

