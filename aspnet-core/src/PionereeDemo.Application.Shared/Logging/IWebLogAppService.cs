using Abp.Application.Services;
using PionereeDemo.Dto;
using PionereeDemo.Logging.Dto;

namespace PionereeDemo.Logging;

public interface IWebLogAppService : IApplicationService
{
    GetLatestWebLogsOutput GetLatestWebLogs();

    FileDto DownloadWebLogs();
}

