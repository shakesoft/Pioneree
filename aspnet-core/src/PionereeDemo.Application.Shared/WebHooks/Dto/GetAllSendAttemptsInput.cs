using PionereeDemo.Dto;

namespace PionereeDemo.WebHooks.Dto;

public class GetAllSendAttemptsInput : PagedInputDto
{
    public string SubscriptionId { get; set; }
}

