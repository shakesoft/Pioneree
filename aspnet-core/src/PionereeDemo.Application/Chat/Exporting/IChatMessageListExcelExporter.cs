using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using PionereeDemo.Chat.Dto;
using PionereeDemo.Dto;

namespace PionereeDemo.Chat.Exporting;

public interface IChatMessageListExcelExporter
{
    Task<FileDto> ExportToFile(UserIdentifier user, List<ChatMessageExportDto> messages);
}