using System.Threading.Tasks;
using PionereeDemo.Security.Recaptcha;

namespace PionereeDemo.Test.Base.Web;

public class FakeRecaptchaValidator : IRecaptchaValidator
{
    public Task ValidateAsync(string captchaResponse)
    {
        return Task.CompletedTask;
    }
}
