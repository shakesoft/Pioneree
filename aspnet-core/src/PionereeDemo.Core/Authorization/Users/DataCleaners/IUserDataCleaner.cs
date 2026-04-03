using Abp;
using System.Threading.Tasks;

namespace PionereeDemo.Authorization.Users.DataCleaners;

public interface IUserDataCleaner
{
    Task CleanUserData(UserIdentifier userIdentifier);
}

