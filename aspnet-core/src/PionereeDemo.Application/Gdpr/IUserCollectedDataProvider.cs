using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using PionereeDemo.Dto;

namespace PionereeDemo.Gdpr;

public interface IUserCollectedDataProvider
{
    Task<List<FileDto>> GetFiles(UserIdentifier user);
}
