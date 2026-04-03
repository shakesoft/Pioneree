using System.Threading.Tasks;
using PionereeDemo.Sessions.Dto;

namespace PionereeDemo.Web.Session;

public interface IPerRequestSessionCache
{
    Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
}

