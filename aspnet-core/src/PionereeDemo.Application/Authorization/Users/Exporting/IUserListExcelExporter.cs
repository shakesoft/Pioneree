using System.Collections.Generic;
using System.Threading.Tasks;
using PionereeDemo.Authorization.Users.Dto;
using PionereeDemo.Dto;

namespace PionereeDemo.Authorization.Users.Exporting;

public interface IUserListExcelExporter
{
    Task<FileDto> ExportToFile(List<UserListDto> userListDtos, List<string> selectedColumns);
}