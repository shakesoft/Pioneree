using PionereeDemo.Maui.Models.NavigationMenu;

namespace PionereeDemo.Maui.Services.Navigation;

public interface IMenuProvider
{
    List<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
}