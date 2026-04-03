using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PionereeDemo.Common.Dto;
using PionereeDemo.Editions.Dto;

namespace PionereeDemo.Common;

public interface ICommonLookupAppService : IApplicationService
{
    Task<ListResultDto<SubscribableEditionComboboxItemDto>> GetEditionsForCombobox(bool onlyFreeItems = false);

    Task<PagedResultDto<FindUsersOutputDto>> FindUsers(FindUsersInput input);

    GetDefaultEditionNameOutput GetDefaultEditionName();
}

