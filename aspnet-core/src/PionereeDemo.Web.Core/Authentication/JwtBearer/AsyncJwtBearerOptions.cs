using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace PionereeDemo.Web.Authentication.JwtBearer;

public class AsyncJwtBearerOptions : JwtBearerOptions
{
    public readonly List<IAsyncSecurityTokenValidator> AsyncSecurityTokenValidators;

    private readonly PionereeDemoAsyncJwtSecurityTokenHandler _defaultAsyncHandler = new PionereeDemoAsyncJwtSecurityTokenHandler();

    public AsyncJwtBearerOptions()
    {
        AsyncSecurityTokenValidators = new List<IAsyncSecurityTokenValidator>() { _defaultAsyncHandler };
    }
}


