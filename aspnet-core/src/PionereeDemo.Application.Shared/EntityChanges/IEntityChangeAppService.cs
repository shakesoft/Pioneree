using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PionereeDemo.EntityChanges.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PionereeDemo.EntityChanges;

public interface IEntityChangeAppService : IApplicationService
{
    Task<ListResultDto<EntityAndPropertyChangeListDto>> GetEntityChangesByEntity(GetEntityChangesByEntityInput input);
}

