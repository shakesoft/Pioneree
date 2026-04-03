using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PionereeDemo.Authorization.Session.Dto;

namespace PionereeDemo.Authorization.Session;

public interface IUserSessionAppService : IApplicationService
{
    Task<ListResultDto<UserSessionDto>> GetSessions(GetUserSessionsInput input);

    Task RevokeSession(EntityDto<long> input);

    Task RevokeAllOtherSessions();
}
