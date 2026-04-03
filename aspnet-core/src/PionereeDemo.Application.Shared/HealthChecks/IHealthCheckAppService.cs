using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PionereeDemo.HealthChecks.Dto;

namespace PionereeDemo.HealthChecks;

public interface IHealthCheckAppService : IApplicationService
{
    Task<ListResultDto<HealthCheckItemDto>> GetHealthChecks();
}
