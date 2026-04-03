using System.Threading.Tasks;
using Abp.Application.Services;
using PionereeDemo.Install.Dto;

namespace PionereeDemo.Install;

public interface IInstallAppService : IApplicationService
{
    Task Setup(InstallDto input);

    AppSettingsJsonDto GetAppSettingsJson();

    CheckDatabaseOutput CheckDatabase();
}
