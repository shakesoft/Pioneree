using Abp.Events.Bus;

namespace PionereeDemo.MultiTenancy.Subscription;

public class SubscriptionCancelledEventData : EventData
{
    public long PaymentId { get; set; }

    public string ExternalPaymentId { get; set; }
}

