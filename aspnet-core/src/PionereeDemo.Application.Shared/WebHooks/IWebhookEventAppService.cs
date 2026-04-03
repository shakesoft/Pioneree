using System.Threading.Tasks;
using Abp.Webhooks;

namespace PionereeDemo.WebHooks;

public interface IWebhookEventAppService
{
    Task<WebhookEvent> Get(string id);
}

