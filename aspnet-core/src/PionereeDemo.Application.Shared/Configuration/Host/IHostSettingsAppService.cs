using System.Threading.Tasks;
using Abp.Application.Services;
using PionereeDemo.Configuration.Host.Dto;

namespace PionereeDemo.Configuration.Host;

public interface IHostSettingsAppService : IApplicationService
{
    Task<HostSettingsEditDto> GetAllSettings();

    Task UpdateAllSettings(HostSettingsEditDto input);

    Task SendTestEmail(SendTestEmailInput input);
}

