using Abp.Events.Bus;

namespace PionereeDemo.MultiTenancy.Subscription;

public class RecurringPaymentsEnabledEventData : EventData
{
    public int TenantId { get; set; }
}

