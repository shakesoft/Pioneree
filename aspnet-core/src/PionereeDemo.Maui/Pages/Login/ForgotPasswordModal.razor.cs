using Microsoft.AspNetCore.Components;
using PionereeDemo.Authorization.Accounts;
using PionereeDemo.Authorization.Accounts.Dto;
using PionereeDemo.Maui.Core.Components;
using PionereeDemo.Maui.Core.Threading;
using PionereeDemo.Maui.Models.Login;

namespace PionereeDemo.Maui.Pages.Login;

public partial class ForgotPasswordModal : ModalBase
{
    public override string ModalId => "forgot-password-modal";

    [Parameter] public EventCallback OnSave { get; set; }

    public ForgotPasswordModel ForgotPasswordModel { get; } = new();

    private readonly IAccountAppService _accountAppService;

    public ForgotPasswordModal()
    {
        _accountAppService = Resolve<IAccountAppService>();
    }

    protected virtual async Task Save()
    {
        await SetBusyAsync(async () =>
        {
            await WebRequestExecuter.Execute(
                async () =>
                    await _accountAppService.SendPasswordResetCode(new SendPasswordResetCodeInput { EmailAddress = ForgotPasswordModel.EmailAddress }),
                async () =>
                {
                    await OnSave.InvokeAsync();
                }
            );
        });
    }

    protected virtual async Task Cancel()
    {
        await Hide();
    }
}