using System.Threading.Tasks;
using Abp.Application.Services;
using PionereeDemo.MultiTenancy.Dto;
using PionereeDemo.MultiTenancy.Payments.Dto;

namespace PionereeDemo.MultiTenancy;

public interface ISubscriptionAppService : IApplicationService
{
    Task DisableRecurringPayments();

    Task EnableRecurringPayments();

    Task<long> StartExtendSubscription(StartExtendSubscriptionInput input);

    Task<StartUpgradeSubscriptionOutput> StartUpgradeSubscription(StartUpgradeSubscriptionInput input);

    Task<long> StartTrialToBuySubscription(StartTrialToBuySubscriptionInput input);
}

