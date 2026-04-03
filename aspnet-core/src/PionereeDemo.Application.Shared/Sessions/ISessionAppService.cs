using System.Threading.Tasks;
using Abp.Application.Services;
using PionereeDemo.Sessions.Dto;

namespace PionereeDemo.Sessions;

public interface ISessionAppService : IApplicationService
{
    Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

    Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
}

