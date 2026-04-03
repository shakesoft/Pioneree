using System.Threading.Tasks;

namespace PionereeDemo.Security.Recaptcha;

public interface IRecaptchaValidator
{
    Task ValidateAsync(string captchaResponse);
}
