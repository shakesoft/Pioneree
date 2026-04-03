using PionereeDemo.ApiClient.Models;

namespace PionereeDemo.Maui.Services.Account;

public interface IAccountService
{
    AbpAuthenticateModel AbpAuthenticateModel { get; set; }

    AbpAuthenticateResultModel AuthenticateResultModel { get; set; }

    Task LoginUserAsync();

    Task LogoutAsync();
}