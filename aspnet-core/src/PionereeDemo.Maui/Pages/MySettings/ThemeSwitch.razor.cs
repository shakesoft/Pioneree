using Microsoft.AspNetCore.Components;
using PionereeDemo.Maui.Core.Components;
using PionereeDemo.Maui.Core.Threading;
using PionereeDemo.Maui.Services.UI;


namespace PionereeDemo.Maui.Pages.MySettings;

public partial class ThemeSwitch : PionereeDemoComponentBase
{
    private string _selectedTheme = ThemeService.GetUserTheme();

    private string[] _themes = ThemeService.GetAllThemes();

    public string SelectedTheme
    {
        get => _selectedTheme;
        set
        {
            _selectedTheme = value;
            AsyncRunner.Run(ThemeService.SetUserTheme(JS, SelectedTheme));
        }
    }
}