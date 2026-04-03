using System.Threading.Tasks;

namespace PionereeDemo.Security;

public interface IPasswordComplexitySettingStore
{
    Task<PasswordComplexitySetting> GetSettingsAsync();
}

