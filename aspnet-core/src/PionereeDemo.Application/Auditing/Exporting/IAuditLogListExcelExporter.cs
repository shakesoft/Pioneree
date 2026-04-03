using PionereeDemo.Auditing.Dto;
using PionereeDemo.Dto;
using PionereeDemo.EntityChanges.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PionereeDemo.Auditing.Exporting;

public interface IAuditLogListExcelExporter
{
    Task<FileDto> ExportToFile(List<AuditLogListDto> auditLogListDtos);

    Task<FileDto> ExportToFile(List<EntityChangeListDto> entityChangeListDtos);
}
