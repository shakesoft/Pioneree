using Abp.Auditing;
using Abp.Mapperly;
using PionereeDemo.Auditing.Dto;
using Riok.Mapperly.Abstractions;

namespace PionereeDemo.Mappers;

[Mapper]
public partial class AuditLogToAuditLogListDtoMapper : MapperBase<AuditLog, AuditLogListDto>
{
    public override partial AuditLogListDto Map(AuditLog source);
    public override partial void Map(AuditLog source, AuditLogListDto destination);
}
