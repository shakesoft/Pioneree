using Microsoft.AspNetCore.Components;
using PionereeDemo.Authorization.Users.Profile;
using PionereeDemo.Authorization.Users.Profile.Dto;
using PionereeDemo.Maui.Core.Components;
using PionereeDemo.Maui.Core.Threading;
using PionereeDemo.Maui.Models.Settings;

namespace PionereeDemo.Maui.Pages.MySettings;

public partial class ChangePasswordModal : ModalBase
{
    [Parameter] public EventCallback OnSave { get; set; }

    public override string ModalId => "change-password";

    public ChangePasswordModel ChangePasswordModel { get; set; } = new();

    private readonly IProfileAppService _profileAppService;

    public ChangePasswordModal()
    {
        _profileAppService = Resolve<IProfileAppService>();
    }

    public override Task Hide()
    {
        ChangePasswordModel = new ChangePasswordModel();
        return base.Hide();
    }

    protected virtual async Task Save()
    {
        await SetBusyAsync(async () =>
        {
            await WebRequestExecuter.Execute(async () =>
            {
                await _profileAppService.ChangePassword(new ChangePasswordInput
                {
                    CurrentPassword = ChangePasswordModel.CurrentPassword,
                    NewPassword = ChangePasswordModel.NewPassword
                });
            }, async () => await OnSave.InvokeAsync());
        });
    }

    protected virtual async Task Cancel()
    {
        await Hide();
    }
}