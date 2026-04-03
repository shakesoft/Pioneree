using System.Globalization;

namespace PionereeDemo.Localization;

public interface IApplicationCulturesProvider
{
    CultureInfo[] GetAllCultures();
}

