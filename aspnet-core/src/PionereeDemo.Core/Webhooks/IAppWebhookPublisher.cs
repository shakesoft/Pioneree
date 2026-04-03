using System.Threading.Tasks;
using PionereeDemo.Authorization.Users;

namespace PionereeDemo.WebHooks;

public interface IAppWebhookPublisher
{
    Task PublishTestWebhook();
}

